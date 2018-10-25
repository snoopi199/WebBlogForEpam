using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBlog.CR;
using WebBlog.Services;

namespace WebBlog.Web.Controllers
{
    public class QuestionnaireController : Controller
    {
        ICreatorOfInctances creatorOfInctances;
        ProviderQuestionnaireQuery commentQuery;

        public QuestionnaireController(ICreatorOfInctances creatorOfInctances)
        {
            this.creatorOfInctances = creatorOfInctances;
            commentQuery = new ProviderQuestionnaireQuery(creatorOfInctances.GetInstanceQuestionnaireQuery());
        }

        public ActionResult Index()
        {
            var questionnaire = commentQuery.GetQuestionnaireByTitle("Оцените пожалуйста наш сайт");
            return View(questionnaire);
        }
        //[HttpPost]
        //public ActionResult QuestionnaireResult(string personName, string recomendations)
        //{     
        //    var questionnaireResult = new QuestionnaireResult(Request.Form, creatorOfInctances.GetInstanceQuestionnaireQuery(),
        //        creatorOfInctances.GetInstanceWebBlogRatingRepository());
            
        //    return View();
        //}

        public ActionResult GetQuestion()
        {
            return PartialView();
        }
    }
}