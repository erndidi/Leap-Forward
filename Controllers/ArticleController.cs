using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LeapForward.Models;
using LeapForward.ViewModels;

namespace LeapForward.Controllers
{
    public class ArticleController : Controller
    {
        //
        // GET: /Article/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Get(int id)
        {
            ArticleVM model = new ArticleVM(id);
           
            return View(model);
        }
	}
}