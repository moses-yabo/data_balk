using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data_balk.Utils;
namespace data_balk.Models
{
    public class Product_model
    {
        public int Trailer_id { get; set; }

        public int Customer_id { get; set; }
        public string Start_Date { get; set; } = "";

        public string End_date { get; set; } = "";

        public int Total_cost { get; set; } = 0;

        public int Fare { get; set; } = 0;


        public TripTypes Trip_role_types { get; set; } = National_trip | Local_trip;



    }
}