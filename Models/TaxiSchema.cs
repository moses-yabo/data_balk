using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data_balk.Utils;

namespace data_balk.Models
{
    public class Taxi_model
    {
        public int Id { get; set; }

        public string Img_url { get; set; } = "";
        public string Description { get; set; } = "";

        public string Capacity { get; set; } = "";

        public bool IsAvailable { get; set; } = false;

        public bool IsBooked { get; set; } = false;

        public TaxiRoles Role { get; set; } = Taxi_driver | Taxi_owner | Taxi_passenger | Trailer_owner;



    }
}