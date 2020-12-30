using CarDealer.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealerServices.ServicesInterfaces
{
    public interface IOptionService
    {
        OptionModel Create(OptionModel option);
        List<OptionModel> GetAll();
        OptionModel GetById(int Id);
        OptionModel Update(OptionModel option);
        void Delete(int Id);
    }
}
