using FinalProject.Web.Areas.Admin.ServiceFacades;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SettingController : Controller
    {
        private readonly SettingServiceFacade _settingServiceFacade;

        public SettingController(SettingServiceFacade settingServiceFacade)
        {
            _settingServiceFacade = settingServiceFacade;
        }

        [HttpGet]
        public async Task<IActionResult> CreateOrUpdate()
        {
            var data = await _settingServiceFacade.GetSettingAsync();
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrUpdate(SettingAddDTO addDto)
        {
            if (!ModelState.IsValid)
            {
                return View(addDto);
            }
            var result = await _settingServiceFacade.CreatOrUpdate(addDto);
            if (result == 0)
            {
                return View(addDto);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
