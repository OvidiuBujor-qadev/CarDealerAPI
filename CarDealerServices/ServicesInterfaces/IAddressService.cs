using CarDealer.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealerServices.ServicesInterfaces
{
    public interface IAddressService
    {
        Address Create(Address address);
        List<Address> GetAll();
        Address GetById(int Id);
        Address Update(Address address);
        void Delete(int Id);
    }
}