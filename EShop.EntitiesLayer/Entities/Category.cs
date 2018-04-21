using EShop.CoreLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.EntitiesLayer.Entities
{
    public class Category:BaseEntity,IEntity
    {
        public int CategoryId { get; set; }
        public String CategoryName { get; set; }
        public String CategoryDescription { get; set; }


    }
}
