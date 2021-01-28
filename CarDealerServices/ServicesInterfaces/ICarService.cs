using CarDealer.Domain;
using CarDealerBusiness.CarDealerDTO;
using System.Collections.Generic;

namespace CarDealerServices.ServicesInterfaces
{
    public interface ICarService
    {
        CarDTO Create(Car car);
        List<CarDTO> GetAll();
        CarDTO GetById(int Id);
        CarDTO Update(Car car);
        void Delete(int Id);
    }
}
