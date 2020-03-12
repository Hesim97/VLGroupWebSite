using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VLGroupWebSite.Entity;

namespace VLGroupWebSite.Repository.Abstract
{
    public interface ICategoryRepository:IGenericRepository<Category>
    {
        Category GetByName(string name);
        void RemoveFromCategory(int ProductId, int CategoryId);
    }
}
