using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.Dal.Context;

namespace MyPortfolyo.ViewComponents
{
    public class _DashboardMetricComponentPartial:ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.DashboardMetrics.ToList();
            return View(values);
        }



    }
}
