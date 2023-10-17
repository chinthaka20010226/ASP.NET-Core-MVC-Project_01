using Microsoft.AspNetCore.Mvc;

namespace ServiceStation.Web.Controllers
{
    public class ServicesController : Controller
    {
        public String HelloWorld() {
            return "This is a ServicesController";
        } 
    }

    // MVC Handller,
    //var servicesController = new ServicesController();
    //servicesController.HelloWorld();
}
