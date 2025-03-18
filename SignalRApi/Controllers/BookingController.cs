using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.BookingDto;
using SignalR.EntiyLAyer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            Booking booking = new Booking()
            {
                Mail = createBookingDto.Mail,
                Date = createBookingDto.Date,
                Name = createBookingDto.Name,
                PersonCount = createBookingDto.PersonCount,
                Phone = createBookingDto.Phone

            };
            _bookingService.TAdd(booking);
            return Ok("Rezarvasyon Yapıldı");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var value = _bookingService.TGetByID(id);
            _bookingService.TDelete(value);
            return Ok("Rezarvasyon Silindi");
        }
        [HttpPut("{id}")]
        public IActionResult UpdateBooking(int id, [FromBody] UpdateBookingDto updateBookingDto)
        {
            var booking = _bookingService.TGetByID(id);

            if (booking == null)
            {
                return NotFound("Güncellenecek rezervasyon bulunamadı.");
            }

            Console.WriteLine($"Önce: {booking.Name}, {booking.PersonCount}, {booking.Date}");

            booking.Mail = updateBookingDto.Mail;
            booking.Date = updateBookingDto.Date;
            booking.Name = updateBookingDto.Name;
            booking.PersonCount = updateBookingDto.PersonCount;
            booking.Phone = updateBookingDto.Phone;

            _bookingService.TUpdate(booking);

 
            Console.WriteLine($"Sonra: {booking.Name}, {booking.PersonCount}, {booking.Date}");

            return Ok("Rezervasyon Güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult Getbooking(int id)
        {
            var value = _bookingService.TGetByID(id);
            return Ok(value);
        }
    }
}
