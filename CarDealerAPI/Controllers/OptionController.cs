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
    public class OptionController : ControllerBase
    {
        private IOptionService _optionService;

        public OptionController(IOptionService optionService)
        {
            _optionService = optionService;
        }

        [HttpPost]
        public async Task<ActionResult<OptionModel>> PostOption(OptionModel option)
        {
            return _optionService.Create(option);
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<OptionModel>>> GetOption()
        {
            return _optionService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OptionModel>> GetOption(int id)
        {
            return _optionService.GetById(id);
        }

        [HttpPut]
        public async Task<ActionResult<OptionModel>> UpdateOption(OptionModel option)
        {
            return _optionService.Update(option);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteOption(int id)
        {
            _optionService.Delete(id);
            return true;
        }
    }
}
