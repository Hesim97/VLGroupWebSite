using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VLGroupWebSite.Entity;
using VLGroupWebSite.Repository.Abstract;

namespace VLGroupWebSite.Repository.Concrete.EntityFramework
{
    public class efOrderRepository:IGenericRepository<Order>,IOrderRepository
    {
        public efOrderRepository(VLGroupContext context)
         : base(context)
        {

        }
    }
}
