using CarDealer.Domain;
using CarDealerBusiness.CarDealerDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealerServices.ServicesInterfaces
{
    public interface IAddressService
    {
        AddressDTO Create(Address address);
        List<AddressDTO> GetAll();
        AddressDTO GetById(int Id);
        AddressDTO Update(Address address);
        void Delete(int Id);
    }
}