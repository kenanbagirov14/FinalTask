using FinalProject.Web.Areas.Admin.ServiceFacades;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GroupController : Controller
    {
        private readonly GroupServiceFacade _groupServiceFacade;

        public GroupController(GroupServiceFacade groupServiceFacade)
        {
            _groupServiceFacade = groupServiceFacade;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var data = await _groupServiceFacade.GetAllAsync();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = _groupServiceFacade.Initialize();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(GroupAddDTO addDto)
        {
            if (!ModelState.IsValid)
            {
                return View(addDto);
            }
            await _groupServiceFacade.AddAsync(addDto);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var model = await _groupServiceFacade.GetByIdAsync(id);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(GroupUpdateDTO updateDto)
        {
            if (!ModelState.IsValid)
            {
                return View(updateDto);
            }
            await _groupServiceFacade.UpdateAsync(updateDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await _groupServiceFacade.DeleteByIdAsync(id);
            return RedirectToAction("Index");
        }
    }
}
