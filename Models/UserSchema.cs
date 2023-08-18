using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data_balk.Utils;
namespace data_balk.Models
{
    public class Users_model
    {
        public int Id { get; set; }

        public string First_name { get; set; } = "";
        public string Last_name { get; set; } = "";

        public string User_name { get; set; } = "";

        public string Password { get; set; } = "";

        public string Email { get; set; } = "";

        public int Role { get; set; } = 0;


        public TaxiRoles Trip_role_types { get; set; } = Taxi_owner | Taxi_driver | Taxi_passenger | Trailer_owner;



    }
}