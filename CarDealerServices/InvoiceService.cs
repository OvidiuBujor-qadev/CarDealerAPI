using CarDealer.Data;
using CarDealer.Domain;
using CarDealerServices.ServicesInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealerServices
{
    public class InvoiceService : IInvoiceService
    {
        private IRepositoryCarDealer InvoiceRepository;

        public InvoiceService(IRepositoryCarDealer _invoiceRepository)
        {
            InvoiceRepository = _invoiceRepository;
        }
        public Invoice Create(Invoice invoice)
        {
            Invoice CreateInvoice = InvoiceRepository.Create<Invoice>(invoice);
            InvoiceRepository.SaveChanges();
            return CreateInvoice;
        }
        public List<Invoice> GetAll()
        {
            List<Invoice> GetAll = InvoiceRepository.Get<Invoice>();
            return GetAll;
        }

        public Invoice GetById(int Id)
        {
            Invoice GetById = InvoiceRepository.GetById<Invoice>(Id);
            return GetById;
        }

        public Invoice Update(Invoice invoice)
        {
            Invoice UpdateCar = InvoiceRepository.Update<Invoice>(invoice);
            InvoiceRepository.SaveChanges();
            return UpdateCar;
        }

        public void Delete(int Id)
        {
            InvoiceRepository.Delete<Invoice>(Id);
        }
    }
}
