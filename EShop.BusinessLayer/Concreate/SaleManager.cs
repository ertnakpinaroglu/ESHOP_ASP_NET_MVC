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
    public class SaleManager : ISaleServices
    {
        private IUnitOfWork _unitOfWork;
        public SaleManager()
        {
            _unitOfWork = new UnitOfWork(new E_Shop_Context());
        }
        public SaleManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void AddBasket(Sale sale)
        {
            _unitOfWork.SaleRepository.AddEntity(sale);
            _unitOfWork.Complete();
        }

        public List<Sale> List()
        {
            return _unitOfWork.SaleRepository.SaleList();
        }
    }
}
