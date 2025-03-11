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
    public class EfAboutDal : GenericRepository<About>, IAboutDal
    {
        public EfAboutDal(SignalRContext context) : base(context)
        {
        }
    }
}
