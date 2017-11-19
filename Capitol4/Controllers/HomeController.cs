using Microsoft.AspNetCore.Mvc;

namespace Capitol4.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View(new string[] {"C#", "Language", "Features" });
        }
    }
}