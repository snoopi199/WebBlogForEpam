using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBlog.Contracts.QueryRepositories;
using WebBlog.Contracts.Repositories;

namespace WebBlog.CR
{
    public interface ICreatorOfInctances
    {
        IArticleQuery GetInstanceArticleQuery();
        ICommentQuery GetInstanceCommentQuery();
        IUserQuery GetInstanceUserQuery();
        IQuestionnaireQuery GetInstanceQuestionnaireQuery();


        IArticleRepository GetInstanceArticleRepository();
        ICommentRepository GetInstanceCommentRepository();
        IUserRepositiory GetInstanceUserRepository();
        IWebBlogRatingRepository GetInstanceWebBlogRatingRepository();

    }
}