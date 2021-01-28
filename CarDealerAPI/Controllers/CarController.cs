using CarDealer.Domain;
using CarDealerBusiness.CarDealerDTO;
using CarDealerServices.ServicesInterfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarDealerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }


        [HttpPost]
        public async Task<ActionResult<CarDTO>> PostCar(Car car)
        {
            return _carService.Create(car);
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<CarDTO>>> GetCar()
        {
            var cars = _carService.GetAll();
            return cars;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CarDTO>> GetCar(int id)
        {
            var car = _carService.GetById(id);
            return car;
        }

        [HttpPut]
        public async Task<ActionResult<CarDTO>> UpdateCar( Car car) 
        {
            return _carService.Update(car);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteCar(int id) 
        {
            _carService.Delete(id);
            return true;
        }
    }
}