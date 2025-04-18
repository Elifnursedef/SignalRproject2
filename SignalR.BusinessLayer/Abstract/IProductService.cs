﻿using SignalR.EntiyLAyer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Abstract
{
   public interface IProductService : IGenericService<Product>
    {
        List<Product> TGetProductswithcategories();

        int TProductCount();
        int TProductCountByCategoryNameHamburger();
        int TProductCountByCategoryNameDirnk();
        decimal TProductPriceAvg();
        string TproductNameByMaxPrice();
        string TproductNameByMinPrice();
        decimal TProductAvgPriceByHamburger();
    }
}
