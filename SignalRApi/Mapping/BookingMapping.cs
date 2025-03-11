using AutoMapper;
using SignalR.DtoLayer.BookingDto;
using SignalR.EntiyLAyer.Entities;

namespace SignalRApi.Mapping
{
    public class BookingMapping:Profile
    {
        public BookingMapping()
        {
            CreateMap<Booking, getbookingDto>().ReverseMap();
            CreateMap<Booking, CreateBookingDto>().ReverseMap();
            CreateMap<Booking, UpdateBookingDto>().ReverseMap();
            CreateMap<Booking, getbookingDto>().ReverseMap();
        }
    }
}
