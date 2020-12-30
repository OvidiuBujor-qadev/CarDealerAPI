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
        public AddressModel Create(AddressModel address)
        {
            AddressModel CreateAddress = AddressRepository.Create<AddressModel>(address);
            AddressRepository.SaveChanges();
            return CreateAddress;
        }
        public List<AddressModel> GetAll()
        {
            List<AddressModel> GetAll = AddressRepository.Get<AddressModel>();
            return GetAll;
        }

        public AddressModel GetById(int Id)
        {
            AddressModel GetById = AddressRepository.GetById<AddressModel>(Id);
            return GetById;
        }

        public AddressModel Update(AddressModel address)
        {
            AddressModel UpdateAddress = AddressRepository.Update<AddressModel>(address);
            AddressRepository.SaveChanges();
            return UpdateAddress;
        }

        public void Delete(int Id)
        {
            AddressRepository.Delete<AddressModel>(Id);
        }
    }
}
