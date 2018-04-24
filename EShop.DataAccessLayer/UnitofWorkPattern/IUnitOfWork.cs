using EShop.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.DataAccessLayer.UnitofWorkPattern
{
    public interface IUnitOfWork : IDisposable
    {
        // IDisposable gerektignde calisir gerekmediginde silinir.
        ICategoryDal CategoryRepository { get; set; }
        ISubCategoryDal SubCategoryRepository { get; set; }

        ICommentDal CommentRepository { get; set; }

        ICustomerDal CustomerRepository { get; set; }
        IProductDal ProductRepository { get; set; }
        ISaleDal SaleRepository { get; set; }
        IFavoriteDal FavoriteRepository { get; set; }

        IBrandDal BrandRepository { get; set; }

        int Complete();

    }
}
