using CarDealer.Data;
using CarDealer.Domain;
using CarDealerServices.ServicesInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealerServices
{
    public class AddressService:IAddressService
    {
        private IRepositoryCarDealer AddressRepository;

        public AddressService(IRepositoryCarDealer _addressRepository) 
        {
            AddressRepository = _addressRepository;
        }
        public Address Create(Address address)
        {
            Address CreateAddress = AddressRepository.Create<Address>(address);
            AddressRepository.SaveChanges();
            return CreateAddress;
        }
        public List<Address> GetAll()
        {
            List<Address> GetAll = AddressRepository.Get<Address>();
            return GetAll;
        }

        public Address GetById(int Id)
        {
            Address GetById = AddressRepository.GetById<Address>(Id);
            return GetById;
        }

        public Address Update(Address address)
        {
            Address UpdateCar = AddressRepository.Update<Address>(address);
            AddressRepository.SaveChanges();
            return UpdateCar;
        }

        public void Delete(int Id)
        {
            AddressRepository.Delete<Address>(Id);
        }
    }
}
