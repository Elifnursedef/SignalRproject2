using Microsoft.EntityFrameworkCore;
using SignalR.EntiyLAyer.Entities;
using SİgnalR.DataAccsessLayer.Abstract;
using SİgnalR.DataAccsessLayer.Concrete;
using SİgnalR.DataAccsessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SİgnalR.DataAccsessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(SignalRContext context) : base(context)
        {
        }

        public List<Product> GetProductswithcategories()
        {
            var context = new SignalRContext();
            var values = context.Products.Include(x => x.Category).ToList();
            return values;
        }
    }
}
