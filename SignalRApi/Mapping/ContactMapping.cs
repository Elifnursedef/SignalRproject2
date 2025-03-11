using AutoMapper;
using SignalR.DtoLayer.ContactDto;
using SignalREntitiyLayer.Entities;

namespace SignalRApi.Mapping
{
    public class ContactMapping:Profile
    {
        public ContactMapping()
        {
            CreateMap<Contact, ResaultContactDto>().ReverseMap();
            CreateMap<Contact, CreatContactDto>().ReverseMap();
            CreateMap<Contact, UpdateContactDto>().ReverseMap();
            CreateMap<Contact, GetContactDto>().ReverseMap();
        }
    }
}
