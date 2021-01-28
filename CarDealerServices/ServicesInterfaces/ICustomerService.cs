using CarDealer.Domain;
using CarDealerBusiness.CarDealerDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealerServices.ServicesInterfaces
{
    public interface ICustomerService
    {
        CustomerDTO Create(Customer customer);
        List<CustomerDTO> GetAll();
        CustomerDTO GetById(int Id);
        CustomerDTO Update(Customer customer);
        void Delete(int Id);
    }
}