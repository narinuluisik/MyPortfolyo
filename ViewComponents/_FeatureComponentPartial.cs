using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyPortfolyo.Dal.Context;

namespace MyPortfolyo.ViewComponents
{
    public class _FeatureComponentPartial:ViewComponent
    {
        MyPortfolioContext portfolioContext= new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values =portfolioContext.Features.ToList();
            return View(values);
        }
    }
}
