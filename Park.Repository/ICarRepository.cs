// Parking - Park.Repository - ICarRepository.cs
// ON: 2023/05/27/11:41 AM
// 
// 
// From: Sebastiano Gaudeano


using Park.Repository.Models;


namespace Park.Repository;

public interface ICarRepository
{
    int AddCar(Car car);
    IQueryable<Car> GetAllAsQueryable();
}