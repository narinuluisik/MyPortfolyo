using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.Dal.Context;

namespace MyPortfolyo.ViewComponents
{
    public class _PortfolioComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Portfolios.ToList();
            return View(values);
        }

    }


}
