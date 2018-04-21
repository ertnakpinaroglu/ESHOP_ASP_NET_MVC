using EShop.CoreLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.EntitiesLayer.Entities
{
    public class Customer:BaseEntity,IEntity
    {
        public int CustomerId { get; set; }
        public String CustomerName { get; set; }
        public String CustomerSurname { get; set; }
        public String Email { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }

    }
}
