using EShop.BusinessLayer.Abstract;
using EShop.EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EShop.MVC.Controllers
{
    public class FavoriteController : Controller
    {
        IProductService _productService;
        IFavoriteServices _favoriteServices;
        public FavoriteController(IProductService productService,IFavoriteServices favoriteServices)
        {
            _productService = productService;
            _favoriteServices = favoriteServices;
        }

        // GET: Favorite
        public ActionResult AddToFavorite(String id)
        {
            // Get Product by id 
            Products favoriteProduct = _productService.GetProductByName(id);
            // Get Customer  
            Customer loginCustomer = Session["loginCustomer"] as Customer;
            Favorite favorite = new Favorite()
            {
                CreatedDate = DateTime.Now,
                ProductId = favoriteProduct.ProductId,
                CustomerId = loginCustomer.CustomerId
            };
            _favoriteServices.AddToFavorite(favorite);

            return RedirectToAction("Index", "Home");

        }
    }
}