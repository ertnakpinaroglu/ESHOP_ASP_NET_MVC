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

            return RedirectToAction("Details","Product",new { id=id });

        }

        // Remove favorite 
        public ActionResult RemoveFavorite(int? id)
        {
            if (id != null)
            {
                Favorite findedFavorite = _favoriteServices.GetFavorite(id);
                _favoriteServices.RemoveFavorite(findedFavorite);
                return RedirectToAction("ListFavorite", "Favorite");
            }
            return View();
        }

        public ActionResult ListFavorite()
        {
            FavoriteViewModel model = new FavoriteViewModel()
            {
                FavoriteList = _favoriteServices.GetFavoriteList(),
                LoginUser = Session["loginCustomer"] as Customer
            };
           
            return View(model);
        }

        public ActionResult DetailsFavorite(int id)
        {
            FavoriteViewModel model = new FavoriteViewModel()
            {
                GetFavorite = _favoriteServices.GetFavorite(id)
            };
            return View(model.GetFavorite);
        }
    }
}