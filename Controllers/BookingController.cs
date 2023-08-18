using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using data_balk.Models;
using Microsoft.AspNetCore.Mvc.Abstractions;
using data_balk.Controllers.Services.BookingService;

namespace data_balk.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Bookings : ControllerBase
    {

        private readonly IBookingService _bookingService;

        public Bookings(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        [Route("GetAll")]
        public ActionResult<Booking_model> Get()
        {
            return Ok(_bookingService.Get_all_booking());
        }
        [HttpGet("{id}")]
        public ActionResult<Booking_model> GetSingle(int id)
        {
            return Ok(_bookingService.Get_booking_byId(id));
        }
        [HttpPost]
        public ActionResult<List<Booking_model>> Create_booking(Booking_model newBooking)
        {
            _bookingService.Book_a_taxi(newBooking);
            return Ok(_bookingService.Get_all_booking());
        }
        // [HttpPost]
        // public IActionInvoker Post()
        // {
        //     return (IActionInvoker)Created("cv", _drivers);
        // }
    }
}
