using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VLGroupWebSite.Models;
using VLGroupWebSite.Models.Membership;
using VLGroupWebSite.Repository.Abstract;
using VLGroupWebSite.Repository.Concrete.EntityFramework;


namespace VLGroupWebSite
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContext<ApplicationIdentityDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContext<VLGroupContext>(options => options.UseSqlServer(Configuration.GetConnectionString("cString")))
                    .AddIdentity<AppUser, AppRole>(options => {
                    options.Password.RequiredLength = 3;
                    options.Password.RequireDigit = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireNonAlphanumeric = false;

                })
                    .AddEntityFrameworkStores<VLGroupContext>()
                    .AddDefaultTokenProviders();
            services.AddMvc();
            services.AddSession();
            services.AddTransient<IProductRepository, efProductRepository>();
            services.AddTransient<ICategoryRepository, efCategoryRepository>();
            services.AddTransient<IUnitOfWork, EfUnitOfWork>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseStatusCodePages();
            app.UseSession();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                     name: "products",
                     template: "products/{category?}",
                     defaults: new { controller = "Product", action = "List" });

                routes.MapRoute(
                       name: "default",
                       template: "{controller=Home}/{action=Index}/{id?}");
            });

            //SeedData.EnsurePopulated(app);

        }
    }
}

