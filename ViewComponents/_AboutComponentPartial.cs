﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyPortfolyo.Dal.Context;

namespace MyPortfolyo.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle = portfolioContext.Abouts.Select(x => x.Title).FirstOrDefault(); 
            ViewBag.aboutSubDescription=portfolioContext.Abouts.Select(x=>x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail=portfolioContext.Abouts.Select(x=>x.Details).FirstOrDefault();

                
            return View();
        }
    }
}
