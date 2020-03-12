using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VLGroupWebSite.Entity;

namespace VLGroupWebSite.Models
{
    public class AdminEditCategoryModel
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<AdminEditProductModel> Products { get; set; }
    }

    public class AdminEditProductModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Image { get; set; }
        public bool IsActiv { get; set; }
        public bool IsHome { get; set; }

    }
}
