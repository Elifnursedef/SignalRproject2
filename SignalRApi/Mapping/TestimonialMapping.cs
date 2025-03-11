using AutoMapper;
using SignalR.DtoLayer.TestimonialDto;
using SignalREntitiyLayer.Entities;

namespace SignalRApi.Mapping
{
    public class TestimonialMapping:Profile
    {
        public TestimonialMapping()
        {
            CreateMap<Testimonial, ResaultTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, CreatTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, GetTestimonialDto>().ReverseMap();
        }
    }
}
