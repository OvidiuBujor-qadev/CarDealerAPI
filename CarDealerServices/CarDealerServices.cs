using System;
using System.Collections.Generic;
using CarDealer.Data;
using CarDealer.Domain;

namespace CarDealerServices
{
    
    public class CarService
    {
        private IRepositoryCarDealer CRep;

        public CarService(IRepositoryCarDealer _cRep) 
        {
            CRep = _cRep;
        }

        public Car Create(Car car) 
        {
            Car CreateCar = CRep.Create(car);
            CRep.SaveChanges();
            return CreateCar;
        }

        public List<Car> GetAll() 
        {
            List<Car> GetAll = CRep.Get<Car>();
            return GetAll;
        }

        public Car GetById(int Id) 
        {
            Car GetById = CRep.GetById<Car>(Id);
            return GetById;
        }

        public Car Update(int Id, Car car) 
        {
            Car UpdateCar = CRep.Update(car);
            CRep.SaveChanges();
            return UpdateCar;
        }

    }
}
