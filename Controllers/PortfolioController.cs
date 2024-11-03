using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.Dal.Context;
using MyPortfolyo.Dal.Entities;

namespace MyPortfolyo.Controllers
{
    public class PortfolioController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        // Portföy içeriğini listeleme
        public IActionResult PortfolioList()
        {
            var values = context.Portfolios.ToList();
            return View(values);
        }

        // Yeni bir portföy içeriği ekleme (GET)
        [HttpGet]
        public IActionResult CreatePortfolio()
        {
            return View();
        }

        // Yeni bir portföy içeriği ekleme (POST)
        [HttpPost]
        public IActionResult CreatePortfolio(Portfolio portfolio)
        {
            context.Portfolios.Add(portfolio);
            context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }

        // Portföy içeriğini silme
        public IActionResult DeletePortfolio(int id)
        {
            var value = context.Portfolios.Find(id);
            if (value != null)
            {
                context.Portfolios.Remove(value);
                context.SaveChanges();
            }
            return RedirectToAction("PortfolioList");
        }

        // Portföy içeriğini güncelleme (GET)
        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            var value = context.Portfolios.Find(id);
            return View(value);
        }

        // Portföy içeriğini güncelleme (POST)
        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio portfolio)
        {
            context.Portfolios.Update(portfolio);
            context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }
    }
}
