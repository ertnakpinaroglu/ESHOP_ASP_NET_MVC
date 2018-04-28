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

        public DbSet<Comment> Comments  { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Sale > Sales{ get; set; }
        public DbSet<Brand> Brands  { get; set; }
        public DbSet<ImageFiles> ImageFiles { get; set; }
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
