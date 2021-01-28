using AutoMapper;
using CarDealer.Data;
using CarDealer.Domain;
using CarDealer.Domain.InputModels;
using CarDealerBusiness.CarDealerDTO;
using CarDealerServices.ServicesInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealerServices
{
    public class InvoiceService : IInvoiceService
    {
        private IRepositoryCarDealer InvoiceRepository;
        private readonly IMapper _mapper;

        public InvoiceService(IRepositoryCarDealer _invoiceRepository, IMapper mapper)
        {
            InvoiceRepository = _invoiceRepository;
            _mapper = mapper;
        }
        public InvoiceDTO Create(Invoice invoice)
        {
            Invoice CreateInvoice = InvoiceRepository.Create<Invoice>(invoice);
            InvoiceDTO invoiceDTO = _mapper.Map<InvoiceDTO>(CreateInvoice);
            InvoiceRepository.SaveChanges();
            return invoiceDTO;
        }
        public List<InvoiceDTO> GetAll()
        {
            List<Invoice> invoices = InvoiceRepository.Get<Invoice>();
            var invoicesDTO = new List<InvoiceDTO>();
            foreach (var invoice in invoices)
            {
                InvoiceDTO invoiceDTO = _mapper.Map<InvoiceDTO>(invoice);
                invoicesDTO.Add(invoiceDTO);
            }
            return invoicesDTO;
        }

        public InvoiceDTO GetById(int Id)
        {
            Invoice invoice = InvoiceRepository.GetById<Invoice>(Id);
            InvoiceDTO invoiceDTO = _mapper.Map<InvoiceDTO>(invoice);
            return invoiceDTO;
        }

        public InvoiceDTO Update(Invoice invoice)
        {
            Invoice updatedInvoice = InvoiceRepository.Update<Invoice>(invoice);
            InvoiceDTO invoiceDTO = _mapper.Map<InvoiceDTO>(updatedInvoice);
            InvoiceRepository.SaveChanges();
            return invoiceDTO;
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
