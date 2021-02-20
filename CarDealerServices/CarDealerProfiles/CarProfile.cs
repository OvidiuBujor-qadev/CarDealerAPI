using AutoMapper;
using CarDealer.Domain;
using CarDealerBusiness.CarDealerDTO;

namespace CarDealerBusiness.CarDealerProfiles
{
    public class CarProfile: Profile
    {
        public CarProfile() 
        {
            CreateMap<Car, CarDTO>();
            CreateMap<CarDTO, Car>();
        }
    }
}
