using CarDealer.Data;
using CarDealer.Domain;
using CarDealer.Domain.InputModels;
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
            Invoice UpdateInvoice = InvoiceRepository.Update<Invoice>(invoice);
            InvoiceRepository.SaveChanges();
            return UpdateInvoice;
        }
        public void Delete(int Id)
        {
            InvoiceRepository.Delete<Invoice>(Id);
        }

        public Invoice Sell(SoldCarModel soldCar) 
        {
            //1. create invoice
            Invoice newInvoice = InvoiceRepository.Create<Invoice>(new Invoice { CustomerId = soldCar.CustomerId, AddressId = soldCar.AddressId, CarId = soldCar.Car.Id});
            //3. Create option invoice (associate invoice id with options)
            var InvoiceOptions = new List<InvoiceOption>();
            foreach (var option in soldCar.Options) 
            {
                InvoiceOptions.Add(InvoiceRepository.Create<InvoiceOption>(new InvoiceOption { OptionId = option.Id, InvoiceId = newInvoice.Id }));
            }
            //4. Add optionInvoice to Invoice
            InvoiceRepository.SaveChanges();

            foreach (var invoiceOption in InvoiceOptions) 
            {
                newInvoice.InvoiceOption.Add(invoiceOption);
            }

            //Mark car as sold

            soldCar.Car.Sold = true;
            InvoiceRepository.Update<Car>(soldCar.Car);

            InvoiceRepository.SaveChanges();
                        
            return newInvoice;
        // 5. save it all

        }
    }
}
