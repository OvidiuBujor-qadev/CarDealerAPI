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
    public class CustomerController : ControllerBase
    {
        private ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        public async Task<ActionResult<CustomerDTO>> PostCustomer(Customer customer)
        {
            return _customerService.Create(customer);
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<CustomerDTO>>> GetCustomer()
        {
            return _customerService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerDTO>> GetCustomer(int id)
        {
            return _customerService.GetById(id);
        }

        [HttpPut]
        public async Task<ActionResult<CustomerDTO>> UpdateCustomer(Customer customer)
        {
            return _customerService.Update(customer);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteCustomer(int id)
        {
            _customerService.Delete(id);
            return true;
        }
    }
}
