using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.Dal.Context;
using MyPortfolyo.Dal.Entities;

namespace MyPortfolyo.Controllers
{
	public class AboutController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();

		// Hakkında içeriğini listeleme
		public IActionResult AboutList()
		{
			var values = context.Abouts.ToList();
			return View(values);
		}

		// Yeni bir hakkında içeriği ekleme (GET)
		[HttpGet]
		public IActionResult CreateAbout()
		{
			return View();
		}

		// Yeni bir hakkında içeriği ekleme (POST)
		[HttpPost]
		public IActionResult CreateAbout(About about)
		{
			context.Abouts.Add(about);
			context.SaveChanges();
			return RedirectToAction("AboutList");
		}

		// Hakkında içeriğini silme
		public IActionResult DeleteAbout(int id)
		{
			var value = context.Abouts.Find(id);
			if (value != null)
			{
				context.Abouts.Remove(value);
				context.SaveChanges();
			}
			return RedirectToAction("AboutList");
		}

		// Hakkında içeriğini güncelleme (GET)
		[HttpGet]
		public IActionResult UpdateAbout(int id)
		{
			var value = context.Abouts.Find(id);
			return View(value);
		}

		// Hakkında içeriğini güncelleme (POST)
		[HttpPost]
		public IActionResult UpdateAbout(About about)
		{
			context.Abouts.Update(about);
			context.SaveChanges();
			return RedirectToAction("AboutList");
		}
	}
}
