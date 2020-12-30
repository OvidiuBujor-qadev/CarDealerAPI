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
        public CustomerModel Create(CustomerModel customer)
        {
            CustomerModel CreateCustomer = CustomerRepository.Create<CustomerModel>(customer);
            CustomerRepository.SaveChanges();
            return CreateCustomer;
        }
        public List<CustomerModel> GetAll()
        {
            List<CustomerModel> GetAll = CustomerRepository.Get<CustomerModel>();
            return GetAll;
        }

        public CustomerModel GetById(int Id)
        {
            CustomerModel GetById = CustomerRepository.GetById<CustomerModel>(Id);
            return GetById;
        }

        public CustomerModel Update(CustomerModel customer)
        {
            CustomerModel UpdateCustomer = CustomerRepository.Update<CustomerModel>(customer);
            CustomerRepository.SaveChanges();
            return UpdateCustomer;
        }

        public void Delete(int Id)
        {
            CustomerRepository.Delete<CustomerModel>(Id);
        }
    }
}
