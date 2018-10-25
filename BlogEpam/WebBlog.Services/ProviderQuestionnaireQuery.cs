using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBlog.Contracts.QueryRepositories;
using WebBlog.Contracts.Repositories;
using WebBlog.Models.Entity;
using WebBlog.Models.Entity.QuestionnaireComponents;

namespace WebBlog.Services
{
    public class ProviderQuestionnaireQuery
    {
        IQuestionnaireQuery questionnaireQuery;
       

        public ProviderQuestionnaireQuery(IQuestionnaireQuery questionnaireQuery)
        {
            this.questionnaireQuery = questionnaireQuery;
           
        }

        public Questionnaire GetQuestionnaireByTitle(string title)
        {
            return questionnaireQuery.GetQuestionnaireByTitle(title);//null error
        }
    }
}