using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using WebBlog.Contracts.QueryRepositories;
using WebBlog.Contracts.Repositories;
using WebBlog.Models.Entity;
using WebBlog.Models.Entity.QuestionnaireComponents;

namespace WebBlog.Services
{
    /// <summary>
    /// The class gives the opportunity to process the user's assessment and add information to the table WebBlogRating
    /// </summary>
    public class QuestionnaireResult     
    {
        private readonly NameValueCollection _form;
        private readonly IQuestionnaireQuery questionnaireQuery;
        private readonly IWebBlogRatingRepository webBlogRatingRepository;

        public QuestionnaireResult(NameValueCollection form, IQuestionnaireQuery questionnaireQuery, 
            IWebBlogRatingRepository webBlogRatingRepository)
        {
            this.questionnaireQuery = questionnaireQuery;
            this.webBlogRatingRepository = webBlogRatingRepository;
            
            _form = form;
        }
        private Questionnaire questionnaire;

        private Questionnaire Questionnaire
        {
            get
            {
                if (questionnaire == null)
                    throw new NullReferenceException();
                else return questionnaire;
            }
            set { questionnaire = value; }
        }

        private int MaxInCheckboxes()
        {
            int max = 0;
            foreach (var question in Questionnaire.Questions)
            {
                if (question.Type == "checkbox")
                {
                    foreach (var answer in question.Answer)
                    {
                        max += answer.Cost;
                    }
                }
            }
            return max;
        }

        private int MaxInRadiobutton()
        {
            int max = 0;
            int maxCount = 0;
            foreach (var question in Questionnaire.Questions)
            {
                if (question.Type == "radiobutton")
                {
                    maxCount = 0;
                    foreach (var answer in question.Answer)
                    {
                        maxCount = (maxCount < answer.Cost) ? maxCount+answer.Cost : maxCount;
                    }
                    max += maxCount;
                }
            }
            return max;
        }

        private int MaxMark()
        {
            return MaxInCheckboxes() + MaxInRadiobutton();
        }

        private ICollection AllIdentifiersFromAnswers()
        {
            var identifiers = new List<string>();
            foreach (var question in Questionnaire.Questions)
            {
                
                    foreach (var answer in question.Answer)
                    {
                        identifiers.Add(answer.Id.ToString());
                    }
                
            }
            return identifiers;
        }

        private void GetQuestionnaire()
        {      
            Questionnaire = questionnaireQuery.GetById(new Guid(_form["questionnaireId"]));
        }

        private int UserMarke()
        {
            int mark = 0;
            //var keysForm = _form.AllKeys;
            //var identifiersOfAllAnswers = AllIdentifiersFromAnswers();
            //var identifiersOfAnswers = ((List<string>)AllIdentifiersFromAnswers())
            //    .Intersect(_form.AllKeys);
            var identifiersOfAnswers = new List<string>();
            foreach (var question in Questionnaire.Questions)
            {
                var checkeds = _form[question.Title];
                if (checkeds == null) continue;
                
                identifiersOfAnswers.AddRange(checkeds.Split(','));               
            }

            foreach (var answerId in identifiersOfAnswers)
            {             
                foreach (var question in Questionnaire.Questions)
                {
                    foreach (var answer in question.Answer)
                    {
                        if (answer.Id.ToString() == answerId)
                        {
                            mark += answer.Cost;
                        }
                            
                    }
                }
            }

            return mark;
        }




        public byte UserEvaluation()
        {
            GetQuestionnaire();
            var userMark = (byte) ((100 * UserMarke()) / MaxMark());
            Report(userMark);
            return userMark;                                     
        }

        private void Report(byte userMark)
        {
            var report = new WebBlogRating
            {
                Id = Guid.NewGuid(),
                Mark = userMark,
                Date = DateTime.Now,
                Suggestion = _form["recomendations"]
            };
            webBlogRatingRepository.Add(report);
        }
    }

}