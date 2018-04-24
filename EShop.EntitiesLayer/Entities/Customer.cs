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
    public class Customer:BaseEntity,IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }
        public String CustomerName { get; set; }
        public String CustomerSurname { get; set; }
        public String Email { get; set; }
        public String Username { get; set; }
        [StringLength(100)]
        public String Password { get; set; }

        public String ProfileImage { get; set; }
        public virtual List<Comment> Comments { get; set; }
        // Bir müşsterinin birden fazla favorite'ı olur 
        public virtual List<Favorite> Favorites  { get; set; }
        public Customer()
        {
            Comments = new List<Comment>();
            Favorites = new List<Favorite>();
        }
    }
}
