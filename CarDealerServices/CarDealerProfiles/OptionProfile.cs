using AutoMapper;
using CarDealer.Domain;
using CarDealerBusiness.CarDealerDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealerBusiness.CarDealerProfiles
{
    public class OptionProfile: Profile
    {
        public OptionProfile() 
        {
            CreateMap<Option, OptionDTO>();
        }
    }
}
