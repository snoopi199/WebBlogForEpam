using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBlog.Models;

namespace WebBlog.Controllers
{

    public class BlogController : Controller
    {
        static DataContext data = new DataContext();
        // GET: Blog
        public ActionResult Main()
        {
            ViewBag.Articles = data.Articles;
            return View();
        }
        
        public ActionResult Article()
        {
            
            ViewBag.Article = (data.Articles as List<Article>)[Convert.ToInt32(Request.Params["id"])];
            return View(); 
        }
        
        public ActionResult Guest()
        {
            return View(data);
        }

        [HttpPost]
        public ActionResult PostGuest(string name, DateTime date, string text)
        {
            data.Comments.Add(new Comment(name, date,text));
            return Redirect("/Blog/Guest");
        }
        public ActionResult Questionnaire()
        {
            return View(data);
        }
        public ActionResult GetQuestion()
        {
            return PartialView();
        }
    }
}