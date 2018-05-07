using EShop.BusinessLayer.Abstract;
using EShop.EntitiesLayer.Entities;
using EShop.MVC.Models;
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
            return View();
        }

        public ActionResult _PartialSearch()
        {
            CategoryViewModel categoryViewModel = new CategoryViewModel()
            {
                LisCategory = _categoryServices.GetListCategory()
            };
            return View(categoryViewModel);
        }

        public ActionResult _PartialCategoryList()
        {
            CategoryViewModel categoryViewModel = new CategoryViewModel()
            {
                LisCategory = _categoryServices.GetListCategory()
            };

            return View(categoryViewModel);
        }
        public ActionResult _PartialCategoryTopList()
        {
            CategoryViewModel categoryViewModel = new CategoryViewModel()
            {
                LisCategory = _categoryServices.GetCategoryTop2()
            };
            return View(categoryViewModel);
        }

        public ActionResult TopMenu()
        {

            return View();
        }

    }
}