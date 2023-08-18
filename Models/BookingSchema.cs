using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data_balk.Utils;
namespace data_balk.Models
{
    public class Booking_model
    {
        public int Id { get; set; }
        public int Passenger_id { get; set; }

        public int Driver_id { get; set; }
        public string Pickup_location { get; set; } = "";

        public string Drop_off_location { get; set; } = "";

        public string Pickup_time { get; set; } = "";

        public int Fare { get; set; } = 10;

        public TaxiRoles Booker_role { get; set; } = Taxi_driver | Taxi_owner | Taxi_passenger | Trailer_owner;

        public TripTypes Trip_role_types { get; set; } = National_trip | Local_trip;



    }
}