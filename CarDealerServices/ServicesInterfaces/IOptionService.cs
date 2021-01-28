using CarDealer.Domain;
using CarDealerBusiness.CarDealerDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealerServices.ServicesInterfaces
{
    public interface IOptionService
    {
        OptionDTO Create(Option option);
        List<OptionDTO> GetAll();
        OptionDTO GetById(int Id);
        OptionDTO Update(Option option);
        void Delete(int Id);
    }
}
