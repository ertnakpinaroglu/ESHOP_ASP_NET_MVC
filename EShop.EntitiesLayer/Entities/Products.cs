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
    public class Products:BaseEntity,IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public String ProductName { get; set; }
        public String ProductDescription { get; set; }
        public float UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

        public String Color { get; set; }
        public String Size { get; set; }

        public int? Star { get; set; }
        // Bir ürünün  bir alt kategorisi olur!

        public int CategoryId { get; set; }
        public  Category Category { get; set; }

        public String ProfileImage { get; set; }
        // FK-Brand
        public Brand Brand { get; set; }
        // Bir ürünün birden fazla yorumu olur 
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Favorite> Favorites { get; set; }
        public Products()
        {
            Comments = new List<Comment>();
            Favorites = new List<Favorite>();
        }


    }
}
