using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.DataAccessLayer.Abstract;
using EShop.DataAccessLayer.DataAccess;
using EShop.DataAccessLayer.Concreate;

namespace EShop.DataAccessLayer.UnitofWorkPattern
{
    public class UnitOfWork : IUnitOfWork
    {
        private E_Shop_Context context;
        
        public UnitOfWork(E_Shop_Context dbContext)
        {
            context = dbContext;
            CategoryRepository = new EfCategoryDal(context); // DI 
            SubCategoryRepository = new EfSubCategoryDal(context);
            CommentRepository = new EfCommentDal(context);
            CustomerRepository = new EfCustomerDal(context);
            ProductRepository = new EfProductDal(context);
            SaleRepository = new EfSaleDal(context);
            FavoriteRepository = new EfFavoriteDal(context);
            BrandRepository = new EfBrandDal(context);
        }

        public ICategoryDal CategoryRepository { get; private set; }
        public ISubCategoryDal SubCategoryRepository { get; private set; }
        public ICommentDal CommentRepository { get; private set; }
        public ICustomerDal CustomerRepository { get; private set; }
        public IProductDal ProductRepository { get; private set; }
        public ISaleDal SaleRepository { get; private set; }
        public IFavoriteDal FavoriteRepository { get; private set; }
        public IBrandDal BrandRepository { get; private set; }

        public int Complete()
        {
            return context.SaveChanges();
            
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
