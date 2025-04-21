using Microsoft.AspNetCore.Mvc;

using MyPortfolyo.Dal.Context;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _AdressComponentPartial : ViewComponent
    {
        MyPortfolioContext db = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = db.Contacts.ToList();
            return View(values);
        }
    }
}