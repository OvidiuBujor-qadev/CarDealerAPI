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

        public CarModel Create(CarModel car) 
        {
            CarModel CreateCar = CarRepository.Create(car);
            CarRepository.SaveChanges();
            return CreateCar;
        }

        public List<CarModel> GetAll() 
        {
            List<CarModel> GetAll = CarRepository.Get<CarModel>();
            return GetAll;
        }

        public CarModel GetById(int Id) 
        {
            CarModel GetById = CarRepository.GetById<CarModel>(Id);
            return GetById;
        }

        public CarModel Update(CarModel car) 
        {
            CarModel UpdateCar = CarRepository.Update<CarModel>(car);
            CarRepository.SaveChanges();
            return UpdateCar;
        }

        public void Delete(int Id) 
        {
            CarRepository.Delete<CarModel>(Id);
        }

    }
}
