using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VLGroupWebSite.Entity;
using VLGroupWebSite.Repository.Abstract;

namespace VLGroupWebSite.Repository.Concrete.EntityFramework
{


    public class efProductRepository : IGenericRepository<Product>, IProductRepository
    {
        public efProductRepository(VLGroupContext context)
           : base(context)
        {

        }
        public VLGroupContext VLGroupContext
        {
            get { return context as VLGroupContext; }
        }
        public List<Product> GetTop5Products()
        {
            return VLGroupContext.Products
                .OrderByDescending(i => i.ProductId)
                .Take(5)
                .ToList();
        }
    }
}
