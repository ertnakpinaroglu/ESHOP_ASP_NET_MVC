using EShop.EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.BusinessLayer.Abstract
{
    public interface IFavoriteServices
    {
        void AddToFavorite(Favorite favorite);

        void RemoveFavorite(Favorite favorite);

        Favorite GetFavorite(int? FavoriteId);

        List<Favorite> GetFavoriteList();

    }
}
