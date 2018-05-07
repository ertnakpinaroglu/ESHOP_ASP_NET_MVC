using EShop.EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.BusinessLayer.Abstract
{
    public interface IProductService
    {
        List<Products> GetList();

        Products GetProductByName(String name);



    }
}
