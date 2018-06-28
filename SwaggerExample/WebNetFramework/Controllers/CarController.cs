using Swashbuckle.Swagger.Annotations;
using System.Collections.Generic;
using System.Net;
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
        /// <response code="200">All cars</response>
        /// <returns></returns>
        [HttpGet]
        [Route("")]
        [SwaggerResponse(HttpStatusCode.OK, "All cars", typeof(Car))]
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