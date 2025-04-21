using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPortfolyo.Dal.Context;
using MyPortfolyo.Dal.Entities;

namespace MyPortfolyo.Controllers
{
    public class DashboardController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult DashboardList()
        {
            var skills = context.Skills.ToList();
            var todos = context.ToDoLists.OrderByDescending(x => x.Date).ToList();

            ViewBag.vs = context.Skills.Count();
            ViewBag.vp = context.Portfolios.Count();
            ViewBag.vt = context.Testimonials.Count();
            ViewBag.vm = context.Messages.Count();

            var tupleData = (skills, todos); // Tuple oluşturduk
            return View(tupleData);
        }
    }
}
