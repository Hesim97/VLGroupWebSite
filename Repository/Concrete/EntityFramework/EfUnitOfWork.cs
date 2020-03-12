using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VLGroupWebSite.Repository.Abstract;

namespace VLGroupWebSite.Repository.Concrete.EntityFramework
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private readonly VLGroupContext dbcontext;
        public EfUnitOfWork(VLGroupContext _dbcontext)
        {
            dbcontext = _dbcontext ?? throw new ArgumentNullException("dbcontext can not be null");
        }
        private IProductRepository _products;
        private ICategoryRepository _categories;
        private IOrderRepository _orders;
        public IProductRepository Product
        {
            get
            {
                return _products ?? (_products = new efProductRepository(dbcontext));
            }
        }

        public ICategoryRepository Categories
        {
            get
            {
                return _categories ?? (_categories=new efCategoryRepository(dbcontext));

            }
        }
        public IOrderRepository Orders
        {
            get
            {
                return _orders ?? (_orders = new efOrderRepository(dbcontext));

            }
        }
        public int SaveChanges()
        {
            try
            {
             return   dbcontext.SaveChanges();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void Dispose()
        {
            dbcontext.Dispose();
        }

     
    }
}
