using CarDealer.Domain;
using CarDealer.Domain.InputModels;
using CarDealerBusiness.CarDealerDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealerServices.ServicesInterfaces
{
    public interface IInvoiceService
    {
        InvoiceDTO Create(Invoice invoice);
        List<InvoiceDTO> GetAll();
        InvoiceDTO GetById(int Id);
        InvoiceDTO Update(Invoice invoice);
        void Delete(int Id);
        Invoice Sell(SoldCarModel soldCar);
    }
}