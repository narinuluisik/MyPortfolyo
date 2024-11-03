using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.Dal.Context;
using MyPortfolyo.Dal.Entities;

namespace MyPortfolyo.Controllers
{
    public class ContactController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        // Hakkında içeriğini listeleme
        public IActionResult ContactList()
        {
            var values = context.Contacts.ToList();
            return View(values);
        }

        // Yeni bir hakkında içeriği ekleme (GET)
        [HttpGet]
        public IActionResult CreateContact()
        {
            return View();
        }

        // Yeni bir hakkında içeriği ekleme (POST)
        [HttpPost]
        public IActionResult CreateContact(Contact contact)
        {
            context.Contacts.Add(contact);
            context.SaveChanges();
            return RedirectToAction("ContactList");
        }

        // Hakkında içeriğini silme
        public IActionResult DeleteContact(int id)
        {
            var value = context.Contacts.Find(id);
            if (value != null)
            {
                context.Contacts.Remove(value);
                context.SaveChanges();
            }
            return RedirectToAction("ContactList");
        }

        // Hakkında içeriğini güncelleme (GET)
        [HttpGet]
        public IActionResult UpdateContact(int id)
        {
            var value = context.Contacts.Find(id);
            return View(value);
        }

        // Hakkında içeriğini güncelleme (POST)
        [HttpPost]
        public IActionResult UpdateContact(Contact contact)
        {
            context.Contacts.Update(contact);
            context.SaveChanges();
            return RedirectToAction("ContactList");
        }
    }
}
