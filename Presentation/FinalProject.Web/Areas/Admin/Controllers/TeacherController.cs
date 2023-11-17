using FinalProject.Application.DTOs.General;
using FinalProject.Application.Interfaces.Services;
using FinalProject.Domain.Entities.General;
using FinalProject.Web.Areas.Admin.ServiceFacades;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeacherController : Controller
    {
        private readonly TeacherServiceFacade _teacherServiceFacade;


        public TeacherController(TeacherServiceFacade teacherServiceFacade)
        {
            _teacherServiceFacade = teacherServiceFacade;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var data = await _teacherServiceFacade.GetAllAsync();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = _teacherServiceFacade.Initialize();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(TeacherAddDTO addDto)
        {
            if (!ModelState.IsValid)
            {
                return View(addDto);
            }
            await _teacherServiceFacade.AddAsync(addDto);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var model = await _teacherServiceFacade.GetByIdAsync(id);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(TeacherUpdateDTO updateDto)
        {
            if (!ModelState.IsValid)
            {
                return View(updateDto);
            }
            await _teacherServiceFacade.UpdateAsync(updateDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await _teacherServiceFacade.DeleteByIdAsync(id);
            return RedirectToAction("Index");
        }
    }
}
