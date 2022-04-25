using System.Collections.Generic;
using API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("cars")]
    [Authorize]
    public class CarController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCars()
        {
            var cars = new List<Car>()
            {
                new Car() {Id = 1, Make = "Volvo", Year = 2010},
                new Car() {Id = 2, Make = "Volvo", Year = 2011},
                new Car() {Id = 3, Make = "Volvo", Year = 2012},
                new Car() {Id = 4, Make = "Volvo", Year = 2013},
                new Car() {Id = 5, Make = "Volvo", Year = 2014},
                new Car() {Id = 6, Make = "Volvo", Year = 2015},
            };
            return Ok(cars);
        }
    }
}