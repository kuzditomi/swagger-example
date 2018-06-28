using System.Collections.Generic;
using System.Web.Http;
using WebNetFramework.Models;

namespace WebNetFramework.Controllers
{
    [RoutePrefix("api/cars")]
    public class CarController : ApiController
    {
        public CarController()
        {

        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetCars()
        {
            var cars = new List<Car>
            {
                new Car {
                   Id = 1
                }
            };

            return Ok(cars);
        }
    }
}