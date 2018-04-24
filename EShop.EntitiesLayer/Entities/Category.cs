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

        // Bir kategorinin birden fazla alt kategorisi olur 
        public virtual List<SubCategory> SubCategories { get; set; } // Navigation prop
        // Bir kategoriye ait birden fazla ürün olur !
        public List<Products> Products { get; set; }

        public Category()
        {
            SubCategories = new List<SubCategory>();
            Products = new List<Products>();
        }

    }
}
