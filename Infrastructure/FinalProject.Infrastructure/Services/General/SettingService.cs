

using FinalProject.Application.DTOs.General;

namespace FinalProject.Infrastructure.Services
{
    public class SettingService : ISettingService
    {
        private readonly ISettingRepository _repository;
        private readonly IMapper _mapper;
        public SettingService (ISettingRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;   
        }
        public async Task<int> AddAsync(SettingAddDTO createModel)
        {
            var entity = _mapper.Map<Setting>(createModel);
            return await _repository.AddAsync(entity);
        }

        public async Task<int> UpdateAsync(SettingAddDTO updateModel)
        {
            var entity = _mapper.Map<Setting>(updateModel);
            return await _repository.UpdateAsync(entity);
        }

        public async Task<SettingAddDTO> GetSettingAsync()
        {
            var data = await _repository.GetSettingAsync();
            if (data == null) 
            {
                return null;
            }
            var settingDto = _mapper.Map<SettingAddDTO>(data);

            return settingDto;
        }
    }
}
