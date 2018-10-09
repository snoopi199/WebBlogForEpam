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
        [HttpGet]
        public ActionResult Questionnaire()
        {
            return View(data);
        }
        [HttpPost]
        public ActionResult Questionnaire(string personName, string recomendations)
        {
            GetDataFromForm();

            var markMax= data.Questions.Where(x => x.Type == "checkbox").Sum(x => x.Answers.Sum(r => r.Cost))
           + data.Questions.Where(x => x.Type == "radiobutton").Sum(x => x.Answers.Max(r => r.Cost));
            var markPerson = MarkPerson();
            ViewBag.Person = personName;
            ViewBag.Recomendations = recomendations;
            ViewBag.MarkMax = markMax;
            ViewBag.MarkPerson = markPerson;
            return View("QuestionnaireResult");
        }


        

        public ActionResult GetQuestion()
        {
            return PartialView();
        }

        private int MarkPerson()
        {
            var questions = (List<Question>)data.Questions;
            int mark = 0;
            for (int i = 0; i < questions.Count; i++)
            {
                if(questions[i].Chekeds.Count!=0)
                {
                    foreach (int index in questions[i].Chekeds)
                    {
                        mark += ((List<Answer>)(questions[i].Answers))[index].Cost;
                    }
                }
                    
            }
            return mark;
        }
        private void GetDataFromForm()
        {
            for (int i = 0; i < data.Questions.Count; i++)
            {
                var questionNumber = "question" + i;
                var checkeds = Request.Form[questionNumber];
                if (checkeds == null)
                {
                    continue;
                }
                var checkedAnsver = ConvertArrayStringToArrayInt(checkeds.Split(','));

                ((List<int>)((List<Question>)(data.Questions))[i].Chekeds).AddRange(checkedAnsver);
            }
        }
        private int[] ConvertArrayStringToArrayInt(string[] arrStr)
        {
            int[] arrInt = new int[arrStr.Length];

            for (int i = 0; i < arrStr.Length; i++)
            {
                arrInt[i] = Convert.ToInt32(arrStr[i]);
            }
            return arrInt;
        }
    }
}