using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Park.Repository.Models;


namespace Park.Repository
{
    public class CarRepository : ICarRepository
    {
        private readonly ParkingDbContext _context;

        public CarRepository(ParkingDbContext context) {
            _context = context;
        }

        public int AddCar(Car car) {
            _context.Cars.Add(car);
            return car.Id;
        }

        public IQueryable<Car> GetAllAsQueryable() {
            var cars = _context.Cars.AsQueryable();
            return cars;
        }
    }
}
