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
    public class EfTestimonialDal : GenericRepository<Testimonial>, ITestimonialDal

    {
        public EfTestimonialDal(SignalRContext context) : base(context)
        {
        }
    }
}
