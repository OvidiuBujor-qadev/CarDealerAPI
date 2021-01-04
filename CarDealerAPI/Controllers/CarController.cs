using CarDealer.Domain;
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
        public async Task<ActionResult<Car>> PostCar(Car car)
        {
            return _carService.Create(car);
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<Car>>> GetCar()
        {
            return _carService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Car>> GetCar(int id)
        {
            return _carService.GetById(id);
        }

        [HttpPut]
        public async Task<ActionResult<Car>> UpdateCar( Car car) 
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