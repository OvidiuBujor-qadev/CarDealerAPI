using CarDealer.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealerServices.ServicesInterfaces
{
    public interface ICustomerService
    {
        Customer Create(Customer customer);
        List<Customer> GetAll();
        Customer GetById(int Id);
        Customer Update(Customer customer);
        void Delete(int Id);
    }
}