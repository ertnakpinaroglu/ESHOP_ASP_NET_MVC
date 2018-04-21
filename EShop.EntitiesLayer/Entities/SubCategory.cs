using EShop.CoreLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.EntitiesLayer.Entities
{
    public class SubCategory:BaseEntity,IEntity
    {
        public int SubCategoryId { get; set; }
        public String SubCategoryName { get; set; }
        public String SubCategoryDescription { get; set; }

    }
}
