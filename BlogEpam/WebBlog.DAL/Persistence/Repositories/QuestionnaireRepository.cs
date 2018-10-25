using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebBlog.DAL.Core.Repositories;
using WebBlog.Entitys;

namespace WebBlog.DAL.Persistence.Repositories
{
    public class QuestionnaireRepository:Repository<Questionnaire>, IQuestionnaireRepository
    {
        public QuestionnaireRepository(BlogContext context) : base(context)
        {

        }
        public BlogContext BlogContext
        {
            get { return Context as BlogContext; }
        }
    }
}