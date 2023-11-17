using FinalProject.Application.DTOs.General;


namespace FinalProject.Application.Interfaces.Services
{
    public interface ISettingService
    {
        Task<int> AddAsync(SettingAddDTO createModel);
        Task<int> UpdateAsync(SettingAddDTO updateModel);
        Task<SettingAddDTO> GetSettingAsync();
    }
}
