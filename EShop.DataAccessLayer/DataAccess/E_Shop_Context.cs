using EShop.EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.DataAccessLayer.DataAccess
{
    public class E_Shop_Context:DbContext
    {
        // Category add 
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories{ get; set; }
        public E_Shop_Context():base("EShopConnStr")
        {

        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Semalar olarak ekle !
        }





    }
}
