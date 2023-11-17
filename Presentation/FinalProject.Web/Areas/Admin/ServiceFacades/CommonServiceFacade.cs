using FinalProject.Domain.Entities.General;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Web.Areas.Admin.ServiceFacades
{
    public class CommonServiceFacade
    {
        private readonly ITeacherService _teacherService;
        private readonly IGroupService _groupService;
        public CommonServiceFacade(ITeacherService teacherService, IGroupService groupService)
        {
            _teacherService = teacherService;
            _groupService = groupService;
        }

        public  async  Task<IEnumerable<SelectListItem>> GetTeacherSelectList()
        {
            var result = await _teacherService.GetAllAsync();
            var response = result.Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Name});
            return response;
        }


        public async Task<IEnumerable<SelectListItem>> GetGroupSelectList()
        {
            var result = await _groupService.GetAllAsync();
            var response = result.Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.GroupName });
            return response;
        }

    }
}
