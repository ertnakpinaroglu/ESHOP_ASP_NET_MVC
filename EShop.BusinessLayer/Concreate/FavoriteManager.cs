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

        public Favorite GetFavorite(int? FavoriteId)
        {
            // get Favorite
            if (FavoriteId != null)
            {
                return unitOfWork.FavoriteRepository.FindEntity(m => m.FavoriteId == FavoriteId);
            }
            return null;
        }

        public List<Favorite> GetFavoriteList()
        {
            return unitOfWork.FavoriteRepository.GetList();
        }

        public void RemoveFavorite(Favorite favorite)
        {
            Favorite findedFavorite = GetFavorite(favorite.FavoriteId);
            if (findedFavorite != null)
            {
                unitOfWork.FavoriteRepository.DeleteEntity(findedFavorite);
                unitOfWork.Complete();
            }
        }

    }
}
