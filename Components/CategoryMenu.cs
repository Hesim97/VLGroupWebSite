using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VLGroupWebSite.Repository.Abstract;

namespace VLGroupWebSite.Components
{
 
    public class CategoryMenu:ViewComponent
    { 
        private IUnitOfWork uow;
        public CategoryMenu(IUnitOfWork _uow)
        {
            uow = _uow;
        }
        public IViewComponentResult Invoke()
        {
            return View(uow.Categories.GetAll());
        }
    }
}
