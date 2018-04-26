using EShop.CoreLayer.DataAccess.Abstract;
using EShop.EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.DataAccessLayer.Abstract
{
    public interface ICategoryDal:IRepository<Category>
    {
        // Category alanına özel kodlar burada tutulacak!
        List<Category> GetListCategoryWithSub();

        List<Category> GetListCategoryTop2();
    }
}
