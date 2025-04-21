using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.Dal.Context;

namespace MyPortfolyo.ViewComponents
{
    public class _TestimonialComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
    var values = portfolioContext.Testimonials.ToList();
    return View(values);
}

        }
   

    }
