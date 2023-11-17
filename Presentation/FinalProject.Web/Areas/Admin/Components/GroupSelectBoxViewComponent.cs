using FinalProject.Web.Areas.Admin.ServiceFacades;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Web.Areas.Admin.Components
{
    public class GroupSelectBoxViewComponent : ViewComponent
    {
        private readonly CommonServiceFacade _commonServiceFacade;
        public GroupSelectBoxViewComponent(CommonServiceFacade commonServiceFacade)
        {
            _commonServiceFacade = commonServiceFacade;
        }

        public async Task<IViewComponentResult> InvokeAsync(int groupId)
        {
            ViewData["selectedValue"] = groupId;
            var data = await _commonServiceFacade.GetGroupSelectList();
            return View(data);
        }
    }
}
