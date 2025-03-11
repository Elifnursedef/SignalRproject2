using SİgnalR.DataAccsessLayer.Abstract;
using SİgnalR.DataAccsessLayer.Concrete;
using SİgnalR.DataAccsessLayer.Repositories;
using SignalREntitiyLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SİgnalR.DataAccsessLayer.EntityFramework
{
    public class EfSocialMediaDal : GenericRepository<SocialMedia>, ISocialMediaDal
    {
        public EfSocialMediaDal(SignalRContext context) : base(context)
        {
        }
    }
}
