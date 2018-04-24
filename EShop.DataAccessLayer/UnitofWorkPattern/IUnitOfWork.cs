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
        ICategoryDal CategoryRepository { get;  }
        ISubCategoryDal SubCategoryRepository { get;  }

        ICommentDal CommentRepository { get;  }

        ICustomerDal CustomerRepository { get; }
        IProductDal ProductRepository { get;  }
        ISaleDal SaleRepository { get;  }
        IFavoriteDal FavoriteRepository { get;  }

        IBrandDal BrandRepository { get;  }

        int Complete();

    }
}
