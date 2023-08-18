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
    public class Taxi : ControllerBase
    {

        private List<Taxi_model> _bookings;

        public Taxi()
        {
            _bookings = new List<Taxi_model>
            {
                new Taxi_model {
                    Id = 0001,
                    Img_url ="image.jpg",
                    Description = "small trailer",
                    Capacity = " Xsmall",
                    IsAvailable = true,
                    IsBooked = false,
                    Role = Taxi_passenger
                    },
                new Taxi_model { Id = 0002,},

                new Taxi_model { Id = 0003,  },
                new Taxi_model { Id = 0004,  }
            };
        }

        [HttpGet]
        [Route("GetAll")]
        public ActionResult<Taxi_model> Get()
        {
            return Ok(_bookings);
        }
        [HttpGet("{id}")]
        public ActionResult<Taxi_model> GetSingle(int id)
        {
            return Ok(_bookings.FirstOrDefault(c => c.Id == id));
        }

        // [HttpPost]
        // public IActionInvoker Post()
        // {
        //     return (IActionInvoker)Created("cv", _drivers);
        // }
    }
}
