using LeapForward.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeapForward.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title="Leap Forward";
return View();
        }
        [HttpPost]
        public string LoadArticle(int id)
        {
            ArticleVM article = new ArticleVM(id);
            return article.Content;
        }
    }
}