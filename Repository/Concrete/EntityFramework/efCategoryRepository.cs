using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VLGroupWebSite.Entity;
using VLGroupWebSite.Repository.Abstract;

namespace VLGroupWebSite.Repository.Concrete.EntityFramework
{
    public class efCategoryRepository : IGenericRepository<Category>, ICategoryRepository
    {
        public efCategoryRepository(VLGroupContext context)
            : base(context)
        {

        }
        public VLGroupContext VLGroupContext
        {
            get { return context as VLGroupContext; }
        }


        public Category GetByName(string name)
        {
           return VLGroupContext.Categories.Where(i=>i.CategoryName==name).FirstOrDefault();
        }

        public void RemoveFromCategory(int ProductId, int CategoryId)
        {
            var cmd = $"delete from ProductCategory where ProductId={ProductId} and CategoryId={CategoryId}";
            context.Database.ExecuteSqlCommand(cmd);
        }
    }
}
