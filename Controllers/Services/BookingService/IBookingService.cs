using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data_balk.Models;

namespace data_balk.Controllers.Services.BookingService
{
    public interface IBookingService
    {
        List<Booking_model> Get_all_booking();
        Booking_model Get_booking_byId(int id);

        List<Booking_model> Book_a_taxi(Booking_model newBookings);



    }
}