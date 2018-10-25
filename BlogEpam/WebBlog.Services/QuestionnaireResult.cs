using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using WebBlog.Contracts.QueryRepositories;
using WebBlog.Contracts.Repositories;

namespace WebBlog.Services
{
    /// <summary>
    /// The class gives the opportunity to process the user's assessment and add information to the table WebBlogRating
    /// </summary>
    public class QuestionnaireResult
        
    {
        private readonly NameValueCollection _form;
        private readonly ProviderQuestionnaireQuery questionnaireQuery;
        private readonly IWebBlogRatingRepository webBlogRatingRepository;

        public QuestionnaireResult(NameValueCollection form, IQuestionnaireQuery questionnaireQuery, 
            IWebBlogRatingRepository webBlogRatingRepository)
        {
            this.questionnaireQuery = new ProviderQuestionnaireQuery(questionnaireQuery);
            this.webBlogRatingRepository = webBlogRatingRepository;
            _form = form;
        }

        
        
    }
}