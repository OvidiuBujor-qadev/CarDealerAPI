using CarDealer.Data;
using CarDealer.Domain;
using CarDealerServices.ServicesInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealerServices
{
    public class CustomerService: ICustomerService
    {
        private IRepositoryCarDealer CustomerRepository;

        public CustomerService(IRepositoryCarDealer _customerService) 
        {
            CustomerRepository = _customerService;
        }
        public Customer Create(Customer customer)
        {
            Customer CreateCustomer = CustomerRepository.Create<Customer>(customer);
            CustomerRepository.SaveChanges();
            return CreateCustomer;
        }
        public List<Customer> GetAll()
        {
            List<Customer> GetAll = CustomerRepository.Get<Customer>();
            return GetAll;
        }

        public Customer GetById(int Id)
        {
            Customer GetById = CustomerRepository.GetById<Customer>(Id);
            return GetById;
        }

        public Customer Update(Customer customer)
        {
            Customer UpdateCustomer = CustomerRepository.Update<Customer>(customer);
            CustomerRepository.SaveChanges();
            return UpdateCustomer;
        }

        public void Delete(int Id)
        {
            CustomerRepository.Delete<Customer>(Id);
        }
    }
}
