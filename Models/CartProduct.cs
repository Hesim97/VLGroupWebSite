using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VLGroupWebSite.Models
{
    public class CartProduct
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ImgName { get; set; }

        public CartProduct(int id, string productName, string imgName)
        {
            this.Id = id;
            this.ProductName = productName;
            this.ImgName = imgName;
        }
    }
}
