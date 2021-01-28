using AutoMapper;
using CarDealer.Data;
using CarDealer.Domain;
using CarDealerBusiness.CarDealerDTO;
using CarDealerServices.ServicesInterfaces;
using System.Collections.Generic;

namespace CarDealerServices
{
    public class AddressService:IAddressService
    {
        private readonly IMapper _mapper;
        private IRepositoryCarDealer AddressRepository;

        public AddressService(IRepositoryCarDealer _addressRepository, IMapper mapper) 
        {
            AddressRepository = _addressRepository;
            _mapper = mapper;
        }
        public AddressDTO Create(Address address)
        {
            Address CreateAddress = AddressRepository.Create<Address>(address);
            AddressDTO addressDTO = _mapper.Map<AddressDTO>(CreateAddress);
            AddressRepository.SaveChanges();
            return addressDTO;
        }
        public List<AddressDTO> GetAll()
        {
            List<Address> addresses = AddressRepository.Get<Address>();
            var addressesDTO = new List<AddressDTO>();
            foreach (var address in addresses)
            {
                AddressDTO addressDTO = _mapper.Map<AddressDTO>(address);
                addressesDTO.Add(addressDTO);
            }
            return addressesDTO;
        }

        public AddressDTO GetById(int Id)
        {
            Address address = AddressRepository.GetById<Address>(Id);
            AddressDTO addressDTO = _mapper.Map<AddressDTO>(address);
            return addressDTO;
        }

        public AddressDTO Update(Address address)
        {
            Address updatedAddress = AddressRepository.Update<Address>(address);
            AddressDTO addressDTO = _mapper.Map<AddressDTO>(updatedAddress);
            AddressRepository.SaveChanges();
            return addressDTO;
        }

        public void Delete(int Id)
        {
            AddressRepository.Delete<Address>(Id);
        }
    }
}
