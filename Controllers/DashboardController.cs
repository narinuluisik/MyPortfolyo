using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.Dal.Context;
using MyPortfolyo.Dal.Entities;

namespace MyPortfolyo.Controllers
{
    public class DashboardController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        // Dashboard içeriğini listeleme
        public IActionResult DashboardList()
        {
            var values = context.DashboardMetrics.ToList();
            return View(values);
        }
    }
}
