﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VLGroupWebSite.Entity;

namespace VLGroupWebSite.Models
{
    public class ProductDetailsModel
    {
        public Product Product { get; set; }
        public List<Image> ProductImages { get; set; }
        public List<ProductAttribute> ProductAttributes { get; set; }
        public List<Category> Categories { get; set; }
    }
}
