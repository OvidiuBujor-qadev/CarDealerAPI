using CarDealer.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealerServices.ServicesInterfaces
{
    public interface IAddressService
    {
        AddressModel Create(AddressModel address);
        List<AddressModel> GetAll();
        AddressModel GetById(int Id);
        AddressModel Update(AddressModel address);
        void Delete(int Id);
    }
}