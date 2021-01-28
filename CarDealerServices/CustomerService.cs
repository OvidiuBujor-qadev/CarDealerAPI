using AutoMapper;
using CarDealer.Data;
using CarDealer.Domain;
using CarDealerBusiness.CarDealerDTO;
using CarDealerServices.ServicesInterfaces;
using System.Collections.Generic;

namespace CarDealerServices
{
    public class CustomerService: ICustomerService
    {
        private IRepositoryCarDealer CustomerRepository;
        private readonly IMapper _mapper;

        public CustomerService(IRepositoryCarDealer _customerService, IMapper mapper) 
        {
            CustomerRepository = _customerService;
            _mapper = mapper;
        }
        public CustomerDTO Create(Customer customer)
        {
            Customer CreateCustomer = CustomerRepository.Create<Customer>(customer);
            CustomerDTO customerDTO = _mapper.Map<CustomerDTO>(CreateCustomer);
            CustomerRepository.SaveChanges();
            return customerDTO;
        }
        public List<CustomerDTO> GetAll()
        {
            List<Customer> customers = CustomerRepository.Get<Customer>();
            var customersDTO = new List<CustomerDTO>();
            foreach (var customer in customers)
            {
                CustomerDTO customerDTO = _mapper.Map<CustomerDTO>(customer);
                customersDTO.Add(customerDTO);
            }
            return customersDTO;
        }

        public CustomerDTO GetById(int Id)
        {
            Customer customer = CustomerRepository.GetById<Customer>(Id);
            CustomerDTO customerDTO = _mapper.Map<CustomerDTO>(customer);
            return customerDTO;
        }

        public CustomerDTO Update(Customer customer)
        {
            Customer updatedCustomer = CustomerRepository.Update<Customer>(customer);
            CustomerDTO customerDTO = _mapper.Map<CustomerDTO>(updatedCustomer);
            CustomerRepository.SaveChanges();
            return customerDTO;
        }

        public void Delete(int Id)
        {
            CustomerRepository.Delete<Customer>(Id);
        }
    }
}
