﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VLGroupWebSite.Entity;

namespace VLGroupWebSite.Repository.Abstract
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        List<Product> GetTop5Products();
    }
}
