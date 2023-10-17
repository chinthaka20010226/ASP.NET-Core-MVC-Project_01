using Microsoft.AspNetCore.Mvc;

namespace ServiceStation.Web.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
