using FinalProject.Web.Models;

namespace FinalProject.Web.ServiceFacades
{
    public class HomeserviceFacade
    {
        private readonly IMessageService _messageService;
        private readonly ISettingService _settingService;
        private readonly ITeacherService _teacherService;
        private static HomeViewModel viewModel ;

        public HomeserviceFacade(IMessageService messageService,  ISettingService settingService, ITeacherService teacherService)
        {
            _messageService = messageService;
            _settingService = settingService;
            _teacherService = teacherService;
        }


        public async Task<int> AddMessage(MessageAddDTO addDto)
        {
            return await _messageService.AddAsync(addDto);
        }

        public  async Task<HomeViewModel> InitializeModel()
        
        {
            if (viewModel == null)
            {
                viewModel = new HomeViewModel();
                viewModel.Teachers = await _teacherService.GetAllAsync();
                viewModel.Setting = await _settingService.GetSettingAsync();
            }

            return await Task.FromResult<HomeViewModel>(viewModel);
        }


        public void ClearViewModel()
        {
            viewModel = null;
        }


    }
}
