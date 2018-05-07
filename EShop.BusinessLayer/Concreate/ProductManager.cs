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
    public class ProductManager : IProductService
    {
        private UnitOfWork unitOfWork;
        public ProductManager()
        {
            unitOfWork = new UnitOfWork(new E_Shop_Context());
        }
        public List<Products> GetList()
        {
            return unitOfWork.ProductRepository.GetProductsWithCategory();
        }

        public Products GetProductByName(String name)
        {
            return unitOfWork.ProductRepository.FindEntity(m => m.ProductName.Equals(name));
        }
    }
}
