using EShop.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.EntitiesLayer.Entities;
using EShop.DataAccessLayer.UnitofWorkPattern;
using EShop.DataAccessLayer.DataAccess;

namespace EShop.BusinessLayer.Concreate
{
    public class CategoryManager : ICategoryServices
    {
        private IUnitOfWork unitOfWork;
        public CategoryManager()
        {
            unitOfWork = new UnitOfWork(new E_Shop_Context());
        }
        public void AddCategory(Category category)
        {
            unitOfWork.CategoryRepository.AddEntity(category);
            unitOfWork.Complete();
        }
    }
}
