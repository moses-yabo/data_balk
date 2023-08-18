using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using data_balk.Models;
using Microsoft.AspNetCore.Mvc.Abstractions;

namespace data_balk.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ProductController : ControllerBase
    {
        private List<Booking_model> _bookings;


        public ProductController()
        {
            _bookings = new List<Booking_model>
            {
                new Booking_model { Passenger_id = 001 ,Driver_id = 002 , Pickup_location = "Nkanini" , Drop_off_location = "Site B", Fare = 200 , Pickup_time = "12",},
                new Booking_model {  },

                new Booking_model { },
                new Booking_model { }
            };
        }

    }
}