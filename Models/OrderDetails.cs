using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VLGroupWebSite.Models
{
    public class OrderDetails
    {
        
        public string Adres { get; set; }
        [Required(ErrorMessage ="Telefon nomresini daxil edin.")]
        public string Telefon { get; set; }
    }
}
