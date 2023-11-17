using FinalProject.Application.DTOs.General;
using FinalProject.Application.Interfaces.Services;
using FinalProject.Domain.Entities.General;
using FinalProject.Web.Areas.Admin.ServiceFacades;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MessageController : Controller
    {
        private readonly MessageServiceFacade _messageServiceFacade;

        public MessageController(MessageServiceFacade messageServiceFacade)
        {
            _messageServiceFacade = messageServiceFacade;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var data = await _messageServiceFacade.GetAllAsync();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = _messageServiceFacade.Initialize();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(MessageAddDTO addDto)
        {
            if (!ModelState.IsValid)
            {
                return View(addDto);
            }
            await _messageServiceFacade.AddAsync(addDto);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var model = await _messageServiceFacade.GetByIdAsync(id);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(MessageUpdateDTO updateDto)
        {
            if (!ModelState.IsValid)
            {
                return View(updateDto);
            }
            await _messageServiceFacade.UpdateAsync(updateDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await _messageServiceFacade.DeleteByIdAsync(id);
            return RedirectToAction("Index");
        }
    }
}
