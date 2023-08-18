using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data_balk.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace data_balk.Controllers.Services.BookingService
{
    public class BookingService : IBookingService
    {

        private static List<Booking_model> Bookings = new List<Booking_model>{
        new Booking_model(),
        new Booking_model{
                   Id = 01010,
                   Driver_id = 0001,
                   Passenger_id = 0002,
                   Booker_role = Taxi_passenger,
                   Drop_off_location = "Epping",
                   Pickup_location = "",
                   Fare = 0,
                   Pickup_time = "",
                   Trip_role_types = National_trip
        }
        };
        public List<Booking_model> Book_a_taxi(Booking_model newBookings)
        {
            Bookings.Add(newBookings);
            return Bookings;
        }

        public List<Booking_model> Get_all_booking()
        {
            return Bookings;
        }

        public Booking_model Get_booking_byId(int id)
        {
            return Bookings.FirstOrDefault(c => c.Id == id);
        }
    }
}