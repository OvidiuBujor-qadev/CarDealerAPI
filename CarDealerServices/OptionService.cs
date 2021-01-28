using AutoMapper;
using CarDealer.Data;
using CarDealer.Domain;
using CarDealerBusiness.CarDealerDTO;
using CarDealerServices.ServicesInterfaces;
using System.Collections.Generic;

namespace CarDealerServices
{
    public class OptionService: IOptionService
    {
        private IRepositoryCarDealer OptionRepository;
        private readonly IMapper _mapper;

        public OptionService(IRepositoryCarDealer _optionService, IMapper mapper)
        {
            OptionRepository = _optionService;
            _mapper = mapper;
        }
        public OptionDTO Create(Option option)
        {
            Option createOption = OptionRepository.Create<Option>(option);
            OptionDTO optionDTO = _mapper.Map<OptionDTO>(createOption);
            OptionRepository.SaveChanges();
            return optionDTO;
        }
        public List<OptionDTO> GetAll()
        {
            List<Option> options = OptionRepository.Get<Option>();
            var optionsDTO = new List<OptionDTO>();
            foreach (var option in options)
            {
                OptionDTO optionDTO = _mapper.Map<OptionDTO>(option);
                optionsDTO.Add(optionDTO);
            }
            return optionsDTO;
        }

        public OptionDTO GetById(int Id)
        {
            Option getById = OptionRepository.GetById<Option>(Id);
            OptionDTO optionDTO = _mapper.Map<OptionDTO>(getById);
            return optionDTO;
        }

        public OptionDTO Update(Option option)
        {
            Option updateOption = OptionRepository.Update<Option>(option);
            OptionDTO optionDTO = _mapper.Map<OptionDTO>(updateOption);
            OptionRepository.SaveChanges();
            return optionDTO;
        }

        public void Delete(int Id)
        {
            OptionRepository.Delete<Option>(Id);
        }
    }
}
