// Parking - Park.Business - IParkService.cs
// ON: 2023/05/27/11:41 AM
// 
// 
// From: Sebastiano Gaudeano


using Park.Business.Dtos;


namespace Park.Business;

public interface IParkService
{
    int AddCar(CarDto car);
    IEnumerable<CarDto> GetAll();
    IEnumerable<int> GetInts(int treshold = 10000);
}