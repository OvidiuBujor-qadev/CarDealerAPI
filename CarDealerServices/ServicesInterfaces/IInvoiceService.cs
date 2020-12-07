using CarDealer.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealerServices.ServicesInterfaces
{
    public interface IInvoiceService
    {
        Invoice Create(Invoice invoice);
        List<Invoice> GetAll();
        Invoice GetById(int Id);
        Invoice Update(Invoice invoice);
        void Delete(int Id);
    }
}