﻿using CarDealer.Domain;
using CarDealerBusiness.CarDealerDTO;
using CarDealerServices.ServicesInterfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        public async Task<ActionResult<OptionDTO>> PostOption(Option option)
        {
            return _optionService.Create(option);
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<OptionDTO>>> GetOption()
        {
            return _optionService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OptionDTO>> GetOption(int id)
        {
            return _optionService.GetById(id);
        }

        [HttpPut]
        public async Task<ActionResult<OptionDTO>> UpdateOption(Option option)
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
