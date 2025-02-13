using Microsoft.AspNetCore.Mvc;

namespace mvc_web_azure_app.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
