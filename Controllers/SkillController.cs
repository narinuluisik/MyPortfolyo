using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.Dal.Context;
using MyPortfolyo.Dal.Entities;

namespace MyPortfolyo.Controllers
{
    public class SkillController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        // Becerileri listeleme
        public IActionResult SkillList()
        {
            var values = context.Skills.ToList();
            return View(values);
        }

        // Yeni bir beceri ekleme (GET)
        [HttpGet]
        public IActionResult CreateSkill()
        {
            return View();
        }

        // Yeni bir beceri ekleme (POST)
        [HttpPost]
        public IActionResult CreateSkill(Skill skill)
        {
            context.Skills.Add(skill);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }

        // Beceriyi silme
        public IActionResult DeleteSkill(int id)
        {
            var value = context.Skills.Find(id);
            if (value != null)
            {
                context.Skills.Remove(value);
                context.SaveChanges();
            }
            return RedirectToAction("SkillList");
        }

        // Beceriyi güncelleme (GET)
        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var value = context.Skills.Find(id);
            return View(value);
        }

        // Beceriyi güncelleme (POST)
        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            context.Skills.Update(skill);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }
    }
}
