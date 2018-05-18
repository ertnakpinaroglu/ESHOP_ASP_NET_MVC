﻿using EShop.BusinessLayer.Abstract;
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
    public class CustomerManager : ICustomerServices
    {
        private IUnitOfWork unitOfWork;
        public CustomerManager()
        {
            unitOfWork = new UnitOfWork(new E_Shop_Context());
        }
        

        public Customer GetCustomerForLogin(Customer customer)
        {
            Customer findCustomer = null;
            if (customer != null)
            {
                findCustomer = unitOfWork.CustomerRepository.FindEntity(m => m.Username.Equals(customer.Username) && m.Password.Equals(customer.Password));

            }
            return findCustomer;
        }

        
    }
}
