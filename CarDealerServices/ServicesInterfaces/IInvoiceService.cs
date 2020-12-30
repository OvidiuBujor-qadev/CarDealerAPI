using CarDealer.Domain;
using CarDealer.Domain.InputModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealerServices.ServicesInterfaces
{
    public interface IInvoiceService
    {
        InvoiceModel Create(InvoiceModel invoice);
        List<InvoiceModel> GetAll();
        InvoiceModel GetById(int Id);
        InvoiceModel Update(InvoiceModel invoice);
        void Delete(int Id);
        InvoiceModel Sell(SoldCarModel soldCar);
    }
}