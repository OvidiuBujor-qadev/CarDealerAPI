using CarDealer.Domain;
using CarDealer.Domain.InputModels;
using CarDealerBusiness.CarDealerDTO;
using CarDealerServices.ServicesInterfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarDealerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private IInvoiceService _invoiceService;

        public InvoiceController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        [HttpPost]
        public async Task<ActionResult<InvoiceDTO>> PostInvoice(Invoice invoice)
        {
            return _invoiceService.Create(invoice);
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<InvoiceDTO>>> GetInvoice()
        {
            return _invoiceService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<InvoiceDTO>> GetInvoice(int id)
        {
            return _invoiceService.GetById(id);
        }

        [HttpPut]
        public async Task<ActionResult<InvoiceDTO>> UpdateInvoice(Invoice invoice)
        {
            return _invoiceService.Update(invoice);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteInvoice(int id)
        {
            _invoiceService.Delete(id);
            return true;
        }
        [Route("api/SellCar")]
        [HttpPost]
        public async Task<ActionResult<Invoice>> SellCar(SoldCarModel soldCar) 
        {
            return _invoiceService.Sell(soldCar);
        }
    }
}