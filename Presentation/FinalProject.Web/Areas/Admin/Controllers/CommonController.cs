using FinalProject.Web.Areas.Admin.ServiceFacades;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Web.Areas.Admin.Controllers
{
    public class CommonController : Controller
    {
        private readonly CommonServiceFacade _commonServiceFacade;

        public CommonController(CommonServiceFacade commonServiceFacade)
        {
            _commonServiceFacade = commonServiceFacade;
        }

        public async Task<IActionResult> TeacherListForSelectBox()
        {
            var teacherList = await _commonServiceFacade.GetTeacherSelectList();
            return Json(teacherList);
        }

        public async Task<IActionResult> GroupListForSelectBox()
        {
            var teacherList = await _commonServiceFacade.GetGroupSelectList();
            return Json(teacherList);
        }
    }
}
