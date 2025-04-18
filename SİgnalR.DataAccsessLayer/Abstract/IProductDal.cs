﻿using SignalR.EntiyLAyer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccsessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<Product> GetProductswithcategories();
        int ProductCount();
        int ProductCountByCategoryNameHamburger();
        int ProductCountByCategoryNameDirnk();
        decimal ProductPriceAvg();
        string productNameByMaxPrice();
        string productNameByMinPrice();
        decimal ProductAvgPriceByHamburger();

    }
}
