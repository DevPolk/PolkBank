using Domain.ViewModels;
using Infrastructure.Entities;
using Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Domain.Controllers
{
    public class HomeController : Controller
    {
        private readonly INewsRepository newsRepository;

        public HomeController(INewsRepository newsRepository)
        {
            this.newsRepository = newsRepository ?? throw new ArgumentNullException(nameof(newsRepository));
        }

        [HttpGet]
        public ActionResult Index()
        {
            var news = newsRepository.GetNews();
            var collection = new BankCollection<News>
            {
                Collection = news.ToList(),
                TotalItems = newsRepository.GetCount(),
                PageIndex = 1,
                PageSize = 3
            };

            return View(collection);
        }

        [HttpPost]
        public PartialViewResult News(int pageIndex, int pageSize)
        {
            var news = newsRepository.GetNews(pageIndex, pageSize);

            var collection = new BankCollection<News>
            {
                Collection = news.ToList(),
                PageIndex = pageIndex,
                PageSize = pageSize,
                TotalItems = newsRepository.GetCount()
            };

            return PartialView("_News", collection);
        }

    }
}