using EShop.BusinessLayer.Abstract;
using EShop.EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EShop.MVC.Controllers
{
    public class BasketController : Controller
    {
        private ISaleServices _saleServices;
        private IProductService _productService;
        public BasketController(ISaleServices saleServices,IProductService productService)
        {
            _saleServices = saleServices;
            _productService = productService;
        }
        // GET: Basket
        public ActionResult List()
        {
            return View();
        }

        public ActionResult AddToBasket(String id)
        {
            Customer loginCustomer = Session["loginCustomer"] as Customer;
            Products products = _productService.GetProductByName(id);
            Sale sale = new Sale()
            {
                CreatedDate = DateTime.Now,
                CustomerId = loginCustomer.CustomerId,
                IsSale = false,
                ProductId = products.ProductId,
                
            };
            _saleServices.AddBasket(sale);
            return RedirectToAction("Index", "Home");
        }
    }
}