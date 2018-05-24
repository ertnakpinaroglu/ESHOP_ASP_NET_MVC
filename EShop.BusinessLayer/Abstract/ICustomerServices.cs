using EShop.EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.BusinessLayer.Abstract
{
    public interface ICustomerServices
    {

        void RegisterCustomer(Customer customer);
        Customer GetCustomerForLogin(Customer customer);

        bool IsAlreadyUsername(Customer customer);
        bool IsAlreadyEmail(Customer customer);


        void UpdateCustomer(Customer customer);


    }
}
