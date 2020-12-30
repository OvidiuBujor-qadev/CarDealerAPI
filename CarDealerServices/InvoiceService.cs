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
        public InvoiceModel Create(InvoiceModel invoice)
        {
            InvoiceModel CreateInvoice = InvoiceRepository.Create<InvoiceModel>(invoice);
            InvoiceRepository.SaveChanges();
            return CreateInvoice;
        }
        public List<InvoiceModel> GetAll()
        {
            List<InvoiceModel> GetAll = InvoiceRepository.Get<InvoiceModel>();
            return GetAll;
        }

        public InvoiceModel GetById(int Id)
        {
            InvoiceModel GetById = InvoiceRepository.GetById<InvoiceModel>(Id);
            return GetById;
        }

        public InvoiceModel Update(InvoiceModel invoice)
        {
            InvoiceModel UpdateInvoice = InvoiceRepository.Update<InvoiceModel>(invoice);
            InvoiceRepository.SaveChanges();
            return UpdateInvoice;
        }
        public void Delete(int Id)
        {
            InvoiceRepository.Delete<InvoiceModel>(Id);
        }

        public InvoiceModel Sell(SoldCarModel soldCar) 
        {
            //1. create invoice
            InvoiceModel newInvoice = InvoiceRepository.Create<InvoiceModel>(new InvoiceModel { CustomerId = soldCar.CustomerId, AddressId = soldCar.AddressId, CarId = soldCar.Car.Id});
            //3. Create option invoice (associate invoice id with options)
            var InvoiceOptions = new List<InvoiceOptionModel>();
            foreach (var option in soldCar.Options) 
            {
                InvoiceOptions.Add(InvoiceRepository.Create<InvoiceOptionModel>(new InvoiceOptionModel { OptionId = option.Id, InvoiceId = newInvoice.Id }));
            }
            //4. Add optionInvoice to Invoice
            InvoiceRepository.SaveChanges();

            foreach (var invoiceOption in InvoiceOptions) 
            {
                newInvoice.InvoiceOption.Add(invoiceOption);
            }

            //Mark car as sold

            soldCar.Car.Sold = true;
            InvoiceRepository.Update<CarModel>(soldCar.Car);

            InvoiceRepository.SaveChanges();
                        
            return newInvoice;
        // 5. save it all

        }
    }
}
