using AutoMapper;
using CarDealer.Domain;
using CarDealerBusiness.CarDealerDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealerBusiness.CarDealerProfiles
{
    public class AddressProfile: Profile
    {
        public AddressProfile() 
        {
            CreateMap<Address, AddressDTO>();
        }
    }
}
