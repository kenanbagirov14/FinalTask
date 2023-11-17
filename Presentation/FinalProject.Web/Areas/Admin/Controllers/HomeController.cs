using FinalProject.Web.ServiceFacades;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Web.Areas.Admin.Controllers
{
   
    [Area("Admin")]
    public class HomeController : Controller
    {
       
        private readonly HomeserviceFacade _homeserviceFacade;
        public HomeController(ILogger<HomeController> logger, HomeserviceFacade homeserviceFacade)
        {

            _homeserviceFacade = homeserviceFacade;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ClearFrontData()
        {
            _homeserviceFacade.ClearViewModel();
            return Redirect("Index");
        }
    }
}
