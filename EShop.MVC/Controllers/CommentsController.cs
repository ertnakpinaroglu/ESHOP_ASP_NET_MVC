using EShop.BusinessLayer.Abstract;
using EShop.EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EShop.MVC.Controllers
{
    public class CommentsController : Controller
    {
        private ICommentServices _commentServices;
        public CommentsController(ICommentServices commentServices)
        {
            _commentServices = commentServices;
        }

        // GET: Comments
        public JsonResult DoComment(String context,int productId)
        {

            Customer loginCustomer = Session["loginCustomer"] as Customer;
            Comment comment = null;
            if (loginCustomer != null)
            {
                 comment = new Comment()
                {
                    IsActive = "Aktif Degil",
                    CreatedDate = DateTime.Now,
                    ProductId = productId,
                    CustomerId = loginCustomer.CustomerId,
                    Text = context,
                    ModifiedDate = DateTime.Now,
                    
                };

                _commentServices.AddComment(comment);
            }
            
            return Json(comment,JsonRequestBehavior.AllowGet);
        }

    }
}