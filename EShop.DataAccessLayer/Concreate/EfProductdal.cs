using EShop.CoreLayer.DataAccess.Concreate;
using EShop.DataAccessLayer.Abstract;
using EShop.DataAccessLayer.DataAccess;
using EShop.EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.DataAccessLayer.Concreate
{
    public class EfProductDal:Repository<Products>,IProductDal
    {
         public E_Shop_Context dbContext { get { return _context as E_Shop_Context; } }
        public EfProductDal(E_Shop_Context context):base(context)
        {

        }

        public List<Products> GetProductsWithCategory()
        {
            return dbContext.Products.Include("Category").ToList();
        }

        public Products GetProductFullInfo(string name)
        {
            return dbContext.Products.Include("Category").Include("Brand").
                Include("Comments").Include("Favorites").Include("ImageFiles").
                Include("Colors").Include("Sizes").
                Where(m => m.ProductName.Equals(name)).FirstOrDefault();
        }
    }
}
