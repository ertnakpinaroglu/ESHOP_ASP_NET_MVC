using EShop.CoreLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.EntitiesLayer.Entities
{
    public class Sale:BaseEntity,IEntity
    {
        public int BasketId { get; set; }

    }
}
