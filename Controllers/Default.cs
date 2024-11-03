using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyo.Controllers
{
    public class Default : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
