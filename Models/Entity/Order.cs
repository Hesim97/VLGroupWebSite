﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VLGroupWebSite.Entity
{
    public class Order
    {
        public Order()
        {
            OrderLines = new List<OrderLine>();
        }
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public double Total { get; set; }
        public DateTime OrderDate { get; set; }
        public EnumOrderState OrderState { get; set; }
        public string UserName { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public virtual List<OrderLine> OrderLines { get; set; }
    }
    public enum EnumOrderState
    {
        [Display(Name="Gozlenilir")]
        Waiting,
       [Display(Name = "Tamamlandi")]
        Completed
    }
}
