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
    public class CustomerController : Controller
    {
        private ICustomerServices _customerServices;
        public CustomerController(ICustomerServices customerServices)
        {
            _customerServices = customerServices;
        }
        // GET: Customer
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Customer customer)
        {
            if (ModelState.IsValid)
            {
                Customer findedCustomer = _customerServices.GetCustomerForLogin(customer);
                if (findedCustomer == null)
                {
                    ModelState.AddModelError("", "Lütfen kullanıcı adınızı ve şifrenizi kontrol ediniz.");
                }
                else
                {
                    Session["loginCustomer"] = findedCustomer;
                    return RedirectToAction("Index", "Home");
                }
               
            }
            return View();
        }

        [HttpPost]
        public ActionResult Register(Customer customer)
        {
            if (ModelState.IsValid)
            {
                // Kullanıcı adı mevcutsa uyarı ver değilse kullan
                if (_customerServices.IsAlreadyEmail(customer)==false && _customerServices.IsAlreadyUsername(customer)==false )
                {
                    customer.CreatedDate = DateTime.Now;
                    customer.ProfileImage = "/Content/Images/ProfileImages/boy.png";
                    _customerServices.RegisterCustomer(customer);
                    return RedirectToAction("Index", "Home");
                }
                else if (_customerServices.IsAlreadyEmail(customer)==true)
                {
                    ModelState.AddModelError("", "Girdiğiniz " + customer.Email + "  mevcut.");

                }
                else if(_customerServices.IsAlreadyUsername(customer)==true)
                {
                    ModelState.AddModelError("", "Girdiğiniz " + customer.Username + " kullanıcı adı mevcut.");
                }

            }
            return View(customer);
           
        }

        public ActionResult MyAccount()
        {
            Customer loginCustomer = Session["loginCustomer"] as Customer;
            CustomerViewModel model = null;
            if (loginCustomer != null)
            {
                 model = new CustomerViewModel()
                {
                    UserAccount = loginCustomer
                };
            }
            return View(model.UserAccount);
        }
        
        public ActionResult UpdateAccount(String txtAd,String txtSoyad,String txtEmail)
        {
            Customer loginCustomer = Session["loginCustomer"] as Customer;
            loginCustomer.CustomerName = txtAd;
            loginCustomer.CustomerSurname = txtSoyad;
            loginCustomer.Email = txtEmail;
            _customerServices.UpdateCustomer(loginCustomer);

            return RedirectToAction("MyAccount", "Customer");

        }

    }
}