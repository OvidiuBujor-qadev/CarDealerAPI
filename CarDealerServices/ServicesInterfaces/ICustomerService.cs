using CarDealer.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealerServices.ServicesInterfaces
{
    public interface ICustomerService
    {
        CustomerModel Create(CustomerModel customer);
        List<CustomerModel> GetAll();
        CustomerModel GetById(int Id);
        CustomerModel Update(CustomerModel customer);
        void Delete(int Id);
    }
}