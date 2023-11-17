using FinalProject.Web.Areas.Admin.ServiceFacades;
using FinalProject.Web.Models;
using FinalProject.Web.ServiceFacades;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FinalProject.Web.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly HomeserviceFacade _homeserviceFacade;
        public HomeController(ILogger<HomeController> logger, HomeserviceFacade homeserviceFacade)
        {
            
            _homeserviceFacade = homeserviceFacade;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _homeserviceFacade.InitializeModel();
            return View(data);
        }


        [HttpPost]
        public async Task<IActionResult> CreateMessage(MessageAddDTO addDto)
        {
            if (!ModelState.IsValid)
            {
                return View(addDto);
            }
            await _homeserviceFacade.AddMessage(addDto);
            return RedirectToAction("Index");
        }




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}