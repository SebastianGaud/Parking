using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Park.Business;
using Park.Business.Dtos;
using Park.Repository;
using Park.Repository.Models;


namespace Parking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly IParkService _parkService;
        private readonly ParkingDbContext _context;

        public CarController(ParkService parkService, ParkingDbContext context) {
            _parkService = parkService;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get(){
            return Ok(_parkService.GetAll());
        }


        [HttpPost]
        public IActionResult Post(CarDto car) {
            var id = _parkService.AddCar(car);

            _context.SaveChanges();
            return Ok(new { id });
        }

        [HttpGet("/ints")]
        public IActionResult GetNumbers(int treshold) {
            var data = _parkService.GetInts().First(x => x == 20);
            return Ok(data);
        }

    }
}
