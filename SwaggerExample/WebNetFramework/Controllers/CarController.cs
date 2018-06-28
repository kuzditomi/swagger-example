using System.Collections.Generic;
using System.Web.Http;
using WebNetFramework.Models;

namespace WebNetFramework.Controllers
{
    /// <summary>
    /// Car related operations
    /// </summary>
    [RoutePrefix("api/cars")]
    public class CarController : ApiController
    {
        /// <summary>
        /// Returns all cars
        /// </summary>
        /// <returns></returns>
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