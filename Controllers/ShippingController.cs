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
    public class Shipping : ControllerBase
    {

        private List<Shipping_model> ShippedProducts;

        public Shipping()
        {
            ShippedProducts = new List<Shipping_model>
            {
                new Shipping_model {
                    Id = 0000001,
                    Taxi_driver = "Madlebe",
                    Taxi_owner = "K. Gunya",
                    Departure = ""


                   },
                new Shipping_model {
                     Id = 0000002,
                    Taxi_driver = "Madlebe",
                    Taxi_owner = "K. Gunya",
                    Departure = ""
                },

                new Shipping_model {
                     Id = 0000003,
                    Taxi_driver = "Madlebe",
                    Taxi_owner = "K. Gunya",
                    Departure = ""
                  },
                new Shipping_model {
                     Id = 00000,
                    Taxi_driver = "Madlebe",
                    Taxi_owner = "K. Gunya",
                    Departure = ""
                }
            };
        }

        [HttpGet]
        [Route("GetAll")]
        public ActionResult<Shipping_model> Get()
        {
            return Ok(ShippedProducts);
        }
        [HttpGet("{id}")]
        public ActionResult<Shipping_model> GetSingle(int id)
        {
            return Ok(ShippedProducts.FirstOrDefault(c => c.Id == id));
        }

        // [HttpPost]
        // public IActionInvoker Post()
        // {
        //     return (IActionInvoker)Created("cv", _drivers);
        // }
    }
}
