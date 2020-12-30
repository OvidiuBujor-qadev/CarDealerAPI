using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.Domain;
using CarDealer.Domain.InputModels;
using CarDealerServices;
using CarDealerServices.ServicesInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<ActionResult<InvoiceModel>> PostInvoice(InvoiceModel invoice)
        {
            return _invoiceService.Create(invoice);
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<InvoiceModel>>> GetInvoice()
        {
            return _invoiceService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<InvoiceModel>> GetInvoice(int id)
        {
            return _invoiceService.GetById(id);
        }

        [HttpPut]
        public async Task<ActionResult<InvoiceModel>> UpdateInvoice(InvoiceModel invoice)
        {
            return _invoiceService.Update(invoice);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteInvoice(int id)
        {
            _invoiceService.Delete(id);
            return true;
        }

        [HttpPost]
        public async Task<ActionResult<InvoiceModel>> PostInvoice(SoldCarModel soldCar) 
        {
            return _invoiceService.Sell(soldCar);
        }
    }
}