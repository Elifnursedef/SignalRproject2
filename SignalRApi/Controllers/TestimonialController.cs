using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.FeatureDto;
using SignalR.DtoLayer.ProductDto;
using SignalR.DtoLayer.TestimonialDto;
using SignalR.EntiyLAyer.Entities;
using SignalREntitiyLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestomanialService _testomanialService;
        private readonly IMapper _mapper;

        public TestimonialController(ITestomanialService testomanialService, IMapper mapper)
        {
            _testomanialService = testomanialService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult TestimonialTest()
        {
            var value = _mapper.Map<List<ResultTestimonialDto>>( _testomanialService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]

        public IActionResult CreateTestimonial(CreateTestimonialDto creatTestimonialDto)
        {
            _testomanialService.TAdd(new Testimonial()
            {
               Comment=creatTestimonialDto.Comment,
               ImageUrl=creatTestimonialDto.ImageUrl,
               Name=creatTestimonialDto.Name,
               Status=creatTestimonialDto.Status,
               Title=creatTestimonialDto.Title

            });
            return Ok("Müşteri Yorum Bilgisi Eklendi");
        }
        [HttpDelete("{id}")]

        public IActionResult DeleteTestimonial(int id)
        {
            var value = _testomanialService.TGetByID(id);
            _testomanialService.TDelete(value);
            return Ok("Müşteri Bilgisi Silindi");
        }
        [HttpGet("{id}")]

        public IActionResult GetTestimonial(int id)
        {
            var value = _testomanialService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]

        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            _testomanialService.TUpdate(new Testimonial()
            {
                Comment = updateTestimonialDto.Comment,
                ImageUrl = updateTestimonialDto.ImageUrl,
                Name = updateTestimonialDto.Name,
                Status = updateTestimonialDto.Status,
                Title = updateTestimonialDto.Title,
                TestimonialID=updateTestimonialDto.TestimonialID
            });
            return Ok("Müşteri Bilgisi Güncellendi");
        }
    }
}
