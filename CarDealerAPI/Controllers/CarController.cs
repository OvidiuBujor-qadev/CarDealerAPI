using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.Data;
using CarDealer.Domain;
using CarDealerServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarDealerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private CarDealerDbContext _context;
        private CarService _carService;

        public CarController(IRepositoryCarDealer repositoryCarDealer)
        {
            _context = new CarDealerDbContext();
            _carService = new CarService(repositoryCarDealer);
        }

        [HttpPost]
        public async Task<ActionResult<Car>> PostCar(Car car)
        {

            return _carService.Create(car);

            //_context.Cars.Add(car);
            //await _context.SaveChangesAsync();

            ////return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            //return car;
        }

        [HttpGet]

        public async Task<ActionResult<ICollection<Car>>> GetCar()
        {
            return await _context.Cars.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Car>> GetCar(int id)
        {
            var existingCar = await _context.Cars.FindAsync(id);

            if (existingCar == null)
            {
                return NotFound();
            }

            return existingCar;
        }

        [HttpPut]
        public async Task<ActionResult<Car>> UpdateCar(Car car) 
        {
            var existingCar = await _context.Cars.FindAsync(car.Id);
            if (existingCar == null)
            {
                return NotFound();
            }

            existingCar = setProperties(car, existingCar);

            await _context.SaveChangesAsync();

            return existingCar;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Car>> DeleteCar(int id) 
        {
            var existingCar = await _context.Cars.FindAsync(id);

            if (existingCar == null)
            {
                return NotFound();
            }
            _context.Cars.Remove(existingCar);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private Car setProperties(Car car, Car existingCar) 
        {
            existingCar.Brand = car.Brand;
            existingCar.Model = car.Model;
            existingCar.Price = car.Price;
            existingCar.Park = car.Brand;
            existingCar.HorsePower = car.HorsePower;
            existingCar.Color = car.Color;
            existingCar.Year = car.Year;
            existingCar.Km = car.Km;
            existingCar.EngineSize = car.EngineSize;
            existingCar.Fuel = car.Fuel;
            existingCar.CarType = car.CarType;
            existingCar.Condition = car.Condition;
            existingCar.Doors = car.Doors;

            return existingCar;
        }
    }
}
