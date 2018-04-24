using EShop.CoreLayer.DataAccess.Concreate;
using EShop.DataAccessLayer.Abstract;
using EShop.EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EShop.DataAccessLayer.DataAccess;

namespace EShop.DataAccessLayer.Concreate
{
    public class EfSubCategoryDal : Repository<SubCategory>, ISubCategoryDal
    {
        //public E_Shop_Context dbContext { get { return _context as E_Shop_Context; } }
        public EfSubCategoryDal(E_Shop_Context context) : base(context)
        {

        }
    }
}
