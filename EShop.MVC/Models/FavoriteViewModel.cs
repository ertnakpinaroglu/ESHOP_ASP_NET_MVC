using System.Collections.Generic;
using EShop.EntitiesLayer.Entities;

namespace EShop.MVC.Models
{
   public class FavoriteViewModel
    {
        public List<Favorite> FavoriteList { get;  set; }
        public Customer LoginUser { get;  set; }
        public Favorite GetFavorite { get;  set; }
    }
}