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
    public class AddressController : ControllerBase
    {
        private IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpPost]
        public async Task<ActionResult<Address>> PostAddress(Address address)
        {
            return _addressService.Create(address);
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<Address>>> GetAddress()
        {
            return _addressService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Address>> GetAddress(int id)
        {
            return _addressService.GetById(id);
        }

        [HttpPut]
        public async Task<ActionResult<Address>> UpdateAddress(Address address)
        {
            return _addressService.Update(address);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteAddress(int id)
        {
            _addressService.Delete(id);
            return true;
        }
    }
}
