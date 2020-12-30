using CarDealer.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealerServices.ServicesInterfaces
{
    public interface ICarService
    {
        CarModel Create(CarModel car);
        List<CarModel> GetAll();
        CarModel GetById(int Id);
        CarModel Update(CarModel car);
        void Delete(int Id);
    }
}
