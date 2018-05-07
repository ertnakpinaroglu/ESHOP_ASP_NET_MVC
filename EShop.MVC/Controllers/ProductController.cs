using EShop.BusinessLayer.Abstract;
using EShop.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EShop.MVC.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productServices;
        public ProductController(IProductService productService)
        {
            _productServices = productService;
        }
        
        // GET: Product
        public ActionResult AllProducts()
        {
            ProductViewModel model = new ProductViewModel()
            {
                ProductList = _productServices.GetList()
            };
            return View(model);
        }

        public ActionResult Details(String name)
        {
            ProductViewModel model = new ProductViewModel()
            {
                ThatProduct = _productServices.GetProductByName(name)
            };
            return View(model.ThatProduct);
        }
    }
}