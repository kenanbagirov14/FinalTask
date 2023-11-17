using FinalProject.Application.Extensions;

namespace FinalProject.Web.Areas.Admin.ServiceFacades
{
    public class SettingServiceFacade
    {
        private readonly ISettingService _settingService;
        private readonly IWebHostEnvironment _env;

        public SettingServiceFacade(ISettingService settingService, IWebHostEnvironment env)
        {
            _settingService = settingService;
            _env = env;
        }

        public async Task<SettingAddDTO> GetSettingAsync()
        {
            SettingAddDTO data = await _settingService.GetSettingAsync();

            if (data == null)
            {
                data = new SettingAddDTO();
            }
            return data;
        }

        public async Task<int> CreatOrUpdate(SettingAddDTO addDto)
        {
            try
            {

                int result = 0;
                if (addDto.AboutImage != null)
                {
                    var aboutImage = await addDto.AboutImage.SaveFileAsync(_env);
                    addDto.AboutImagePath = aboutImage.Item1;
                    addDto.AboutFullImagePath = aboutImage.Item2;
                }

                if (addDto.LogoImage != null)
                {
                    var logoImagePath = await addDto.LogoImage.SaveFileAsync(_env);
                    addDto.LogoImagePath = logoImagePath.Item1 ;
                    addDto.LogoImageFullPath = logoImagePath.Item2 ;
                }
                if (addDto.SlideImage != null)
                {
                    var slideImagePath = await addDto.SlideImage.SaveFileAsync(_env);
                    addDto.SlideImagePath = slideImagePath.Item1 ;
                    addDto.SlideImageFullPath = slideImagePath.Item2;
                }
                if (addDto.WhyUseImage != null)
                {
                    var whyUsImagePath = await addDto.WhyUseImage.SaveFileAsync(_env);
                    addDto.WhyUsImagePath = whyUsImagePath.Item1;
                    addDto.WhyUsFullImagePath = whyUsImagePath.Item2;
                }

                if (addDto.WhyUseImage1 != null)
                {
                    var whyUsImagePath1 = await addDto.WhyUseImage1.SaveFileAsync(_env);
                    addDto.WhyUsImagePath1 = whyUsImagePath1.Item1;
                    addDto.WhyUsFullImagePath1 = whyUsImagePath1.Item2;
                }

                if (addDto.WhyUseImage2 != null)
                {
                    var whyUsImagePath2 = await addDto.WhyUseImage2.SaveFileAsync(_env);
                    addDto.WhyUsImagePath2 = whyUsImagePath2.Item1;
                    addDto.WhyUsFullImagePath2 = whyUsImagePath2.Item2;
                }

                if (addDto.Id == 0)
                {
                    result = await _settingService.AddAsync(addDto);
                }
                else
                {
                    result = await _settingService.UpdateAsync(addDto);
                }

                return result;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
