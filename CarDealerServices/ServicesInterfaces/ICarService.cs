using CarDealer.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealerServices.ServicesInterfaces
{
    public interface ICarService
    {
        Car Create(Car car);
        List<Car> GetAll();
        Car GetById(int Id);
        Car Update(Car car);
        void Delete(int Id);
    }
}
