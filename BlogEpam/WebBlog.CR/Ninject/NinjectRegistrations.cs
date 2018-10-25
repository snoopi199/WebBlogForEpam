using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBlog.Contracts.QueryRepositories;
using WebBlog.Contracts.Repositories;
using WebBlog.DB.QueryRepositories;
using WebBlog.DB.Repositories;

namespace WebBlog.CR.Ninject
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IArticleQuery>().To<ArticleQuery>();
            Bind<ICommentQuery>().To<CommentQuery>();
            Bind<IUserQuery>().To<UserQuery>();
            Bind<IQuestionnaireQuery>().To<QuestionnaireQuery>();

            Bind<IArticleRepository>().To<ArticleRepository>();
            Bind<ICommentRepository>().To<CommentRepository>();
            Bind<IUserRepositiory>().To<UserRepositiory>();
            Bind<IWebBlogRatingRepository>().To<WebBlogRatingRepository>();
            

        }
    }
}