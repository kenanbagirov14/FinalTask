using FinalProject.Application.DTOs.General;
using FinalProject.Application.Interfaces.Services;
using FinalProject.Domain.Entities.General;
using FinalProject.Web.Areas.Admin.ServiceFacades;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StudentController : Controller
    {
        private readonly StudentServiceFacade _studentServiceFacade;

        public StudentController(StudentServiceFacade studentServiceFacade)
        {
            _studentServiceFacade = studentServiceFacade;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            
            var data = await _studentServiceFacade.GetAllAsync();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = _studentServiceFacade.Initialize();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(StudentAddDTO addDto)
        {
            if (!ModelState.IsValid)
            {
                return View(addDto);
            }
            await _studentServiceFacade.AddAsync(addDto);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var model = await _studentServiceFacade.GetByIdAsync(id);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(StudentUpdateDTO updateDto)
        {
            if (!ModelState.IsValid)
            {
                return View(updateDto);
            }
            await _studentServiceFacade.UpdateAsync(updateDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await _studentServiceFacade.DeleteByIdAsync(id);
            return RedirectToAction("Index");
        }
    }
}
