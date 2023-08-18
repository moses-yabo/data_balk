using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data_balk.Utils;
namespace data_balk.Models
{
    public class Shipping_model
    {
        public int Id { get; set; }

        public string Fleet_no { get; set; } = "";
        public string Taxi_driver { get; set; } = "";
        public string Taxi_owner { get; set; } = "";
        public string Departure { get; set; } = "";
        public string Destination { get; set; } = "";
        public string Time_stamp { get; set; } = "";

    }
}