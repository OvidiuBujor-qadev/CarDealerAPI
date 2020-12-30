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
        public OptionModel Create(OptionModel option)
        {
            OptionModel CreateOption = OptionRepository.Create<OptionModel>(option);
            OptionRepository.SaveChanges();
            return CreateOption;
        }
        public List<OptionModel> GetAll()
        {
            List<OptionModel> GetAll = OptionRepository.Get<OptionModel>();
            return GetAll;
        }

        public OptionModel GetById(int Id)
        {
            OptionModel GetById = OptionRepository.GetById<OptionModel>(Id);
            return GetById;
        }

        public OptionModel Update(OptionModel option)
        {
            OptionModel UpdateOption = OptionRepository.Update<OptionModel>(option);
            OptionRepository.SaveChanges();
            return UpdateOption;
        }

        public void Delete(int Id)
        {
            OptionRepository.Delete<OptionModel>(Id);
        }
    }
}
