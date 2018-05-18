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

        public Sale GetSaleById(int id)
        {
            return _unitOfWork.SaleRepository.FindEntity(m => m.SaleId == id);
        }

        public List<Sale> List(Customer customer)
        {
            return _unitOfWork.SaleRepository.SaleList(customer);
        }

        public void RemoveBasket(int id)
        {
            Sale deletedSale = GetSaleById(id);
            _unitOfWork.SaleRepository.DeleteEntity(deletedSale);
            _unitOfWork.Complete();
        }
    }
}
