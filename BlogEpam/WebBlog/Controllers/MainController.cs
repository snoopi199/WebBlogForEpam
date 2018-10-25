using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBlog.Services;
using WebBlog.CR;
using WebBlog.Models.Entity;

namespace WebBlog.Web.Controllers
{
    public class MainController : Controller
    {
        ICreatorOfInctances creatorOfInctances;
        ProviderArticleQuery articleQuery;

        public MainController(ICreatorOfInctances creatorOfInctances)
        {
            this.creatorOfInctances = creatorOfInctances;
            articleQuery = new ProviderArticleQuery(creatorOfInctances.GetInstanceArticleQuery());
        }       

        public ActionResult Index()
        {    
            var allArticles = articleQuery.GetAllArticles().ToList();
                 
            return View(allArticles);
        }

        public ActionResult Article()
        {
            var article = articleQuery.GetArticle(new Guid(Request.Params["id"]));           
            return View(article);
        }
    }
}