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
    public class Sale:BaseEntity,IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SaleId { get; set; }

        public bool IsSale { get; set; } // false:basket,true:sale

        public int ProductId { get; set; }
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
        public Products Product { get; set; }




    }
}
