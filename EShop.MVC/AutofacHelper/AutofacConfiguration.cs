using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Autofac.Integration.Mvc;
using System.Reflection;
using EShop.DataAccessLayer.UnitofWorkPattern;
using EShop.BusinessLayer.Concreate;
using EShop.BusinessLayer.Abstract;
using System.Web.Mvc;

namespace EShop.MVC.AutofacHelper
{
    public static class AutofacConfiguration
    {
        public static void Config()
        {
            // get builder 
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

                        
            builder.RegisterType<CategoryManager>().As<ICategoryServices>();
            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<CustomerManager>().As<ICustomerServices>();
            builder.RegisterType<SaleManager>().As<ISaleServices>();
            builder.RegisterType<FavoriteManager>().As<IFavoriteServices>();
            builder.RegisterType<CommentManager>().As<ICommentServices>();

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));



        }
    }
}