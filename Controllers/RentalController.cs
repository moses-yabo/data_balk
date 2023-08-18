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
    public class Rental : ControllerBase
    {

        private List<Rental_model> Rentals;

        public Rental()
        {
            Rentals = new List<Rental_model>
            {
                new Rental_model {

                    Customer_id = 00001,
                    Trailer_id = 0002,
                    Start_Date = "17/08/2023",
                    End_date = "23/08/2023",
                    Fare = 20,
                    Total_cost = 200,

                   },
                new Rental_model {
                    Customer_id = 00002,
                    Trailer_id = 0003,
                    Start_Date = "17/08/2023",
                    End_date = "23/08/2023",
                    Fare = 20,
                    Total_cost = 200,
                },

                new Rental_model {
                    Customer_id = 00001,
                    Trailer_id = 00002,
                    Start_Date = "17/08/2023",
                    End_date = "23/08/2023",
                    Fare = 20,
                    Total_cost = 200,
                  },
                new Rental_model {
                    Customer_id = 00001,
                    Trailer_id = 00002,
                    Start_Date = "17/08/2023",
                    End_date = "23/08/2023",
                    Fare = 20,
                    Total_cost = 200,
                }
            };
        }

        [HttpGet]
        [Route("GetAll")]
        public ActionResult<Rental_model> Get()
        {
            return Ok(Rentals);
        }
        [HttpGet("{id}")]
        public ActionResult<Rental_model> GetSingle(int id)
        {
            return Ok(Rentals.FirstOrDefault(c => c.Id == id));
        }

        // [HttpPost]
        // public IActionInvoker Post()
        // {
        //     return (IActionInvoker)Created("cv", _drivers);
        // }
    }
}
