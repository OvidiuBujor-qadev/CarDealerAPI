using System;
using System.Collections.Generic;
using CarDealer.Data;
using CarDealer.Domain;
using CarDealerServices.ServicesInterfaces;

namespace CarDealerServices
{
    
    public class CarService: ICarService
    {
        private IRepositoryCarDealer CarRepository;

        public CarService(IRepositoryCarDealer _carRepository) 
        {
            CarRepository = _carRepository;
        }

        public Car Create(Car car) 
        {
            Car CreateCar = CarRepository.Create(car);
            CarRepository.SaveChanges();
            return CreateCar;
        }

        public List<Car> GetAll() 
        {
            List<Car> GetAll = CarRepository.Get<Car>();
            return GetAll;
        }

        public Car GetById(int Id) 
        {
            Car GetById = CarRepository.GetById<Car>(Id);
            return GetById;
        }

        public Car Update(Car car) 
        {
            Car UpdateCar = CarRepository.Update<Car>(car);
            CarRepository.SaveChanges();
            return UpdateCar;
        }

        public void Delete(int Id) 
        {
            CarRepository.Delete<Car>(Id);
        }

    }
}
