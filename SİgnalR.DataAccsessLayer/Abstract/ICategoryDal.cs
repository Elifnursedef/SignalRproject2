﻿using SignalR.EntiyLAyer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccsessLayer.Abstract
{
    public interface ICategoryDal:IGenericDal<Category>
    {
         int CategoryCount();
         int ActiveCategoryCount();
         int PassiveCategoryCount();

    }
}
