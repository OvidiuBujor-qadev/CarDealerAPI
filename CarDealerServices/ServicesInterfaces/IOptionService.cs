using CarDealer.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealerServices.ServicesInterfaces
{
    public interface IOptionService
    {
        Option Create(Option option);
        List<Option> GetAll();
        Option GetById(int Id);
        Option Update(Option option);
        void Delete(int Id);
    }
}
