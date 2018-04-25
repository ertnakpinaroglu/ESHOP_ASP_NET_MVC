using EShop.BusinessLayer.Abstract;
using EShop.EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EShop.MVC.Controllers
{
    public class HomeController : Controller
    {
        private ICategoryServices _categoryServices;
        public HomeController(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }
        public ActionResult Index()
        {
            Category category = new Category()
            {
                CategoryDescription = "deneme 2",
                CategoryName = "adi bu olsun 2 ",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                RemovedDate = DateTime.Now
            };
            _categoryServices.AddCategory(category);

            return View();
        }

   
    }
}