﻿using EShop.CoreLayer.DataAccess.Concreate;
using EShop.DataAccessLayer.Abstract;
using EShop.DataAccessLayer.DataAccess;
using EShop.EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.DataAccessLayer.Concreate
{
    public class EfFavoriteDal:Repository<Favorite>,IFavoriteDal
    {
        // public E_Shop_Context dbContext { get { return _context as E_Shop_Context; } }
        public EfFavoriteDal(E_Shop_Context context):base(context)
        {

        }
    }
}
