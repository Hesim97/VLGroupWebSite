using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VLGroupWebSite.Entity;

namespace VLGroupWebSite.Repository.Concrete.EntityFramework
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.GetRequiredService<VLGroupContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                var products = new[]
                {
                    new Product(){ProductName="Pencere",Price=200, Image="testIm1.jpg",IsActiv=true,IsHome=true,Description="desc3",DateAdded=DateTime.Now.AddDays(-1)},
                    new Product(){ProductName="Qapi",Price=350, Image="testIm2.png",IsActiv=true,IsHome=true,Description="desc2",DateAdded=DateTime.Now.AddDays(-3)},
                    new Product(){ProductName="Jaluz",Price=140, Image="winss.jpg",IsActiv=true,IsHome=true,Description="desc1",DateAdded=DateTime.Now.AddDays(-5)}

                };
                context.Products.AddRange(products);
                var categories = new[]
                {
                    new Category(){CategoryName="Jaluz"},
                    new Category(){CategoryName="Pəncərə"},
                    new Category(){CategoryName="Qapı"}
                };
                context.Categories.AddRange(categories);
                var productcategory = new[]
                {
                    new ProductCategory(){Product=products[0],Category=categories[1]},
                    new ProductCategory(){Product=products[1],Category=categories[2]},
                    new ProductCategory(){Product=products[2],Category=categories[1]}
                };
                context.AddRange(productcategory);
                var images = new[]
                {
                    new Image(){ImageName="testIm1.jpg",Product=products[0]},
                    new Image(){ImageName="testIm5.jpg",Product=products[0]},
                    new Image(){ImageName="testIm10.jpg",Product=products[1]},

                    new Image(){ImageName="testIm2.png",Product=products[1]},
                    new Image(){ImageName="testIm7.jpg",Product=products[1]},
                    new Image(){ImageName="testIm11.jpg",Product=products[1]},

                    new Image(){ImageName="testIm1.jpg",Product=products[2]},
                    new Image(){ImageName="testIm5.jpg",Product=products[2]},
                    new Image(){ImageName="testIm10.jpg",Product=products[2]}
               };
                context.Images.AddRange(images);

                var attributes = new[]
                {
                    new ProductAttribute(){Attribute="Material",Value="Taxta",Product=products[0]},
                    new ProductAttribute(){Attribute="Marka",Value="Marka1",Product=products[0]},

                    new ProductAttribute(){Attribute="Material",Value="Suse",Product=products[1]},
                    new ProductAttribute(){Attribute="Marka",Value="Marka2",Product=products[1]},

                    new ProductAttribute(){Attribute="Material",Value="Plaspen",Product=products[2]},
                    new ProductAttribute(){Attribute="Marka",Value="Marka3",Product=products[2]},

                };
                context.Attributes.AddRange(attributes);
                context.SaveChanges();
            }
        }
    }
}
