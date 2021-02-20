using AutoMapper;
using CarDealer.Data;
using CarDealer.Domain;
using CarDealerBusiness.CarDealerDTO;
using CarDealerServices.ServicesInterfaces;
using System.Collections.Generic;

namespace CarDealerServices
{

    public class CarService: ICarService
    {
        private readonly IMapper _mapper;
        private IRepositoryCarDealer CarRepository;

        public CarService(IRepositoryCarDealer _carRepository, IMapper mapper) 
        {
            CarRepository = _carRepository;
            _mapper = mapper;
        }

        public CarDTO Create(Car car) 
        {
            Car createCar = CarRepository.Create(car);
            CarRepository.SaveChanges();
            CarDTO carDTO = _mapper.Map<CarDTO>(createCar);
            return carDTO;
        }

        public List<CarDTO> GetAll() 
        {
            List<Car> cars = CarRepository.Get<Car>();
            List<CarDTO> listCarsDTO = _mapper.Map<List<Car>, List<CarDTO>>(cars);
            //foreach (var car in cars)
            //{
            //    CarDTO carDTO = _mapper.Map<CarDTO>(car);
            //    carsDTO.Add(carDTO);
            //}
            return listCarsDTO;
        }

        public CarDTO GetById(int Id) 
        {
            Car car = CarRepository.GetById<Car>(Id);
            CarDTO carDTO = _mapper.Map<CarDTO>(car);
            return carDTO;
        }

        public CarDTO Update(Car car) 
        {
            Car updatedCar = CarRepository.Update<Car>(car);
            CarDTO carDTO = _mapper.Map<CarDTO>(updatedCar);
            CarRepository.SaveChanges();
            return carDTO;
        }

        public void Delete(int Id) 
        {
            CarRepository.Delete<Car>(Id);
        }

    }
}
