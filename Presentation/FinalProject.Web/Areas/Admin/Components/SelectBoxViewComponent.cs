using FinalProject.Web.Areas.Admin.ServiceFacades;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Web.Areas.Admin.Components
{
    public class SelectBoxViewComponent : ViewComponent 
    {
        private readonly CommonServiceFacade _commonServiceFacade;

        public SelectBoxViewComponent(CommonServiceFacade commonServiceFacade)
        {
            _commonServiceFacade = commonServiceFacade;
        }

        public async Task<IViewComponentResult> InvokeAsync(int teacherId)
        {
            ViewData["selectedValue"] = teacherId;
            var data = await _commonServiceFacade.GetTeacherSelectList();
            return View(data);
        }

        //public IViewComponentResult Invoke()
        //{
        //    var items =  _commonServiceFacade.GetTeacherSelectList().Result;
        //    return View(items);
        //}
    }
}
