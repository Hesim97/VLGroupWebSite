using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VLGroupWebSite.Entity;
using VLGroupWebSite.Models;
using VLGroupWebSite.Models.Membership;

namespace VLGroupWebSite.Repository.Concrete.EntityFramework
{

    //public class IdentityDbContext<TUser, TRole, TKey> : IdentityDbContext<TUser, TRole, TKey, IdentityUserClaim<TKey>, IdentityUserRole<TKey>, IdentityUserLogin<TKey>, IdentityRoleClaim<TKey>, IdentityUserToken<TKey>>
    public class VLGroupContext : IdentityDbContext<AppUser, AppRole,int, AppUserClaim, AppUserRole, AppUserLogin, AppRoleClaim, AppUserToken>
    {
        public VLGroupContext(DbContextOptions<VLGroupContext> options)
            : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<ProductAttribute> Attributes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>()
              .HasKey(pk => new { pk.ProductId, pk.CategoryId });
            modelBuilder.Entity<AppUserLogin>()
              .HasKey(pk => new { pk.UserId, pk.ProviderKey });
            modelBuilder.Entity<AppUserRole>()
              .HasKey(pk => new { pk.UserId, pk.RoleId });
            modelBuilder.Entity<AppUserToken>()
              .HasKey(pk => new { pk.UserId, pk.Value });
        }

        public DbSet<VLGroupWebSite.Entity.ProductCategory> ProductCategory { get; set; }
    }
}
