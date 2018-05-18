using EShop.EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.BusinessLayer.Abstract
{
    public interface ISaleServices
    {
        void AddBasket(Sale sale);

        List<Sale> List();
    }
}
