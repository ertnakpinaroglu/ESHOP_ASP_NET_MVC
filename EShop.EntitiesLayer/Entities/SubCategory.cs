using EShop.CoreLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.EntitiesLayer.Entities
{
    public class SubCategory:BaseEntity,IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubCategoryId { get; set; }
        public String SubCategoryName { get; set; }
        public String SubCategoryDescription { get; set; }
        // [ForeignKey("Category")]
        public int CategoryId { get; set; } // FK 
        // Bir alt kategori bir kategoriye aittir.
        public virtual Category Category { get; set; }
        // Bir alt kategorinin birden fazla ürünü olur !
        public List<Products> Products { get; set; }
        public SubCategory()
        {
            Products = new List<Products>();
        }
    }
}
