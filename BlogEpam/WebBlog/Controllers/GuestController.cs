using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBlog.CR;
using WebBlog.Models.Entity;
using WebBlog.Services;

namespace WebBlog.Web.Controllers
{
    public class GuestController : Controller
    {
        ICreatorOfInctances creatorOfInctances;
        ProviderCommentQuery commentQuery;

        public GuestController(ICreatorOfInctances creatorOfInctances)
        {
            this.creatorOfInctances = creatorOfInctances;
            commentQuery = new ProviderCommentQuery(creatorOfInctances.GetInstanceCommentQuery(),
                creatorOfInctances.GetInstanceCommentRepository(),creatorOfInctances.GetInstanceUserQuery(),
                creatorOfInctances.GetInstanceUserRepository());
        }
        // GET: GuestPage

        [HttpGet]
        public ActionResult Index()
        {
            var comments = commentQuery.GetCommentsByType("GuestPage").ToList();  
            
            return View(comments);
        }

        [HttpPost]
        public ActionResult Index(string email, string name, DateTime date, string text)
        {
            commentQuery.AddCommentForGuestPage(email, name, date, text);
            return Redirect("/Guest/Index");
        }
    }
}