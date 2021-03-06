﻿using EShop.CoreLayer.DataAccess.Abstract;
using EShop.EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.DataAccessLayer.Abstract
{
    public interface IProductDal:IRepository<Products>
    {
        List<Products> GetProductsWithCategory();

        Products GetProductFullInfo(String name);
    }
}
