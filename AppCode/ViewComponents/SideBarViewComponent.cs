using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VLGroupWebSite
{
    public class SideBarViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string filter)
        {
            return View();
        }
    }
}
