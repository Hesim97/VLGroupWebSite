using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VLGroupWebSite.Helpers;
using VLGroupWebSite.Infrastructure;
using VLGroupWebSite.Models;

namespace VLGroupWebSite.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        public string Invoke()
        {
            return HttpContext.Session.GetJson<Cart>("Cart")?.Products.Count().ToString() ?? "0";
        }
    }
}
