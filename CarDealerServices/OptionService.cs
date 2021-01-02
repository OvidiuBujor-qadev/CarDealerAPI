using CarDealer.Data;
using CarDealer.Domain;
using CarDealerServices.ServicesInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealerServices
{
    public class OptionService: IOptionService
    {
        private IRepositoryCarDealer OptionRepository;

        public OptionService(IRepositoryCarDealer _optionService)
        {
            OptionRepository = _optionService;
        }
        public Option Create(Option option)
        {
            Option CreateOption = OptionRepository.Create<Option>(option);
            OptionRepository.SaveChanges();
            return CreateOption;
        }
        public List<Option> GetAll()
        {
            List<Option> GetAll = OptionRepository.Get<Option>();
            return GetAll;
        }

        public Option GetById(int Id)
        {
            Option GetById = OptionRepository.GetById<Option>(Id);
            return GetById;
        }

        public Option Update(Option option)
        {
            Option UpdateOption = OptionRepository.Update<Option>(option);
            OptionRepository.SaveChanges();
            return UpdateOption;
        }

        public void Delete(int Id)
        {
            OptionRepository.Delete<Option>(Id);
        }
    }
}
