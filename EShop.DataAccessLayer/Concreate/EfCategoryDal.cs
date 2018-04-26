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
    public class EfCategoryDal:Repository<Category>,ICategoryDal
    {
         public E_Shop_Context dbContext { get { return _context as E_Shop_Context; } }
        public EfCategoryDal(E_Shop_Context shop_Context):base(shop_Context)
        {
            
        }

        public List<Category> GetListCategoryWithSub()
        {
            return dbContext.Categories.Include("SubCategories").ToList();
        }

        public List<Category> GetListCategoryTop2()
        {
            return dbContext.Categories.Include("SubCategories").Take(2).ToList();
        }
    }
}
