using Park.Business.Dtos;
using Park.Repository;
using Park.Repository.Models;


namespace Park.Business;

public class ParkService : IParkService
{
    // la logica per aggiungere una macchina la database
    private readonly ICarRepository _carRepository;

    public ParkService(ICarRepository carRepository) {
        _carRepository = carRepository;
    }

    public int AddCar(CarDto car) {
        var dbC = _carRepository.GetAllAsQueryable().FirstOrDefault(x => x.Id == car.Id);

        if (dbC != null) {
            throw new Exception("L'auto esiste già");
        }

        return _carRepository.AddCar(new Car {
            Model = car.Model,
            Name = car.Name,
            Plate = car.Plate
        });
    }

    public IEnumerable<CarDto> GetAll() {
        var cs = _carRepository.GetAllAsQueryable()
            .Select(x => new CarDto {
                Id = x.Id,
                Name = x.Name,
                Plate = x.Plate,
                Model = x.Model
            });

        return cs;
    }


    public IEnumerable<int> GetInts(int treshold = 10000) {
        for (var i = 0; i < 10000; i++) {
            yield return i;
        }
    }
}