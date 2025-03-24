using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.CategoryDto;
using SignalR.DtoLayer.ContactDto;
using SignalR.EntiyLAyer.Entities;
using SignalREntitiyLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService categoryService, IMapper mapper)
        {
            _contactService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ContactList()
        {
            var value = _mapper.Map<List<ResultContactDto>>(_contactService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]

        public IActionResult CreateContact(CreatContactDto creatContactDto)
        {
            _contactService.TAdd(new Contact()
            {
                FooterDescription= creatContactDto.FooterDescription,
                Location=creatContactDto.Location,
                Mail=creatContactDto.Mail,
                Phone=creatContactDto.Phone
            });
            return Ok("İletişim Bilgisi Eklendi");
        }
        [HttpDelete("{id}")]

        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.TGetByID(id);
            _contactService.TDelete(value);
            return Ok("İletişim Bilgisi Silindi");
        }
        [HttpGet("{id}")]

        public IActionResult GetContact(int id)
        {
            var value = _contactService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]

        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {
            _contactService.TUpdate(new Contact()
            {
              ContactID=updateContactDto.ContactID,
              FooterDescription=updateContactDto.FooterDescription,
              Location=updateContactDto.Location,
              Mail=updateContactDto.Mail,
              Phone=updateContactDto.Phone
            });
            return Ok("İletişim Bilgisi Güncellendi");
        }
    }
}
