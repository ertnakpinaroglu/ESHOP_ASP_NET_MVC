using EShop.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.EntitiesLayer.Entities;
using EShop.DataAccessLayer.UnitofWorkPattern;
using EShop.DataAccessLayer.DataAccess;

namespace EShop.BusinessLayer.Concreate
{
    public class FavoriteManager : IFavoriteServices
    {
        private IUnitOfWork unitOfWork;
        public FavoriteManager()
        {
            unitOfWork = new UnitOfWork(new E_Shop_Context());
        }
        
        
        public void AddToFavorite(Favorite favorite)
        {
            unitOfWork.FavoriteRepository.AddEntity(favorite);
            unitOfWork.Complete();
        }


    }
}
