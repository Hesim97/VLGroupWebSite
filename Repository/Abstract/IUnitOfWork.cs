using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VLGroupWebSite.Repository.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Product { get; }
        ICategoryRepository Categories { get; }
        IOrderRepository Orders { get; }
        int SaveChanges();
    }
}
