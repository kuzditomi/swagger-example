using Swashbuckle.Swagger.Annotations;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using System.Web.Http.ModelBinding;
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
        [SwaggerResponse(HttpStatusCode.OK, "All cars", typeof(Car[]))]
        public IHttpActionResult GetCars()
        {
            var cars = new List<Car>
            {
                new Car {
                   Id = 1,
                   PlateNumber= "ABC-123"
                }
            };

            return Ok(cars);
        }

        /// <summary>
        /// Returns car with given Id
        /// </summary>
        /// <param name="id">Unique id of car</param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}")]
        [SwaggerResponse(HttpStatusCode.NotFound, "No car with given Id")]
        [SwaggerResponse(HttpStatusCode.OK, "Returns car with given Id", typeof(Car))]
        public IHttpActionResult GetCar(int id)
        {
            if (id != 1)
            {
                return NotFound();
            }

            return Ok(new Car
            {
                Id = 1,
                PlateNumber = "ABC-123"
            });
        }

        /// <summary>
        /// Adds new car to system with given plate number
        /// </summary>
        /// <param name="car">Car creation data</param>
        /// <returns></returns>
        [HttpPost]
        [Route("")]
        [SwaggerResponse(HttpStatusCode.BadRequest, "The request is invalid.", typeof(ModelStateDictionary))]
        [SwaggerResponse(HttpStatusCode.Conflict, "Car with given plate already exists")]
        [SwaggerResponse(HttpStatusCode.OK, "Returns added car", typeof(Car))]
        public IHttpActionResult AddCar(CarCreate car)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (car.PlateNumber == "ABC-123")
            {
                return Conflict();
            }

            return Ok(new Car
            {
                Id = 2,
                PlateNumber = car.PlateNumber
            });
        }
    }
}