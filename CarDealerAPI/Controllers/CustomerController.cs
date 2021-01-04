using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.Domain;
using CarDealerServices.ServicesInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<ActionResult<Customer>> PostCustomer(Customer customer)
        {
            return _customerService.Create(customer);
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<Customer>>> GetCustomer()
        {
            return _customerService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomer(int id)
        {
            return _customerService.GetById(id);
        }

        [HttpPut]
        public async Task<ActionResult<Customer>> UpdateCustomer(Customer customer)
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
