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
    public class Brand:BaseEntity,IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BrandId { get; set; }
        public String BrandName { get; set; }
        public String IconImage { get; set; }
        // Bir markanın birden fazla ürünü olur 
        public List<Products> Products { get; set; }
        public Brand()
        {
            Products = new List<Products>();
        }
    }
}
