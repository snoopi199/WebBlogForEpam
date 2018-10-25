using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBlog.Contracts.QueryRepositories;
using WebBlog.Contracts.Repositories;

namespace WebBlog.CR
{
    /// <summary>
    /// The class allows to not interact with the database and get implementation the instances.
    /// </summary>
    public class CreatorOfInctances : ICreatorOfInctances
    {
        private readonly IArticleQuery _instanceArticleQuery;
        private readonly ICommentQuery _instanceCommentQuery;
        private readonly IUserQuery _instanceUserQuery;
        private readonly IQuestionnaireQuery _instanceQuestionnaireQuery;

        private readonly IArticleRepository _instanceArticleRepository;
        private readonly ICommentRepository _instanceCommentRepository;
        private readonly IUserRepositiory _instanceUserRepositiory;
        private readonly IWebBlogRatingRepository _instanceWebBlogRatingRepository;

        public CreatorOfInctances(IArticleQuery articleQuery, ICommentQuery commentQuery, 
             IUserQuery userQuery, IArticleRepository articleRepository,
             ICommentRepository commentRepository,IUserRepositiory userRepositiory,
             IQuestionnaireQuery questionnaireQuery, IWebBlogRatingRepository webBlogRatingRepository)
        {
            _instanceArticleQuery = articleQuery;
            _instanceCommentQuery = commentQuery;
            _instanceUserQuery = userQuery;
            _instanceQuestionnaireQuery = questionnaireQuery;

            _instanceArticleRepository = articleRepository;
            _instanceCommentRepository = commentRepository;
            _instanceUserRepositiory = userRepositiory;
            _instanceWebBlogRatingRepository = webBlogRatingRepository;
        }

        public IArticleQuery GetInstanceArticleQuery() => _instanceArticleQuery;

        public ICommentQuery GetInstanceCommentQuery() => _instanceCommentQuery;

        public IUserQuery GetInstanceUserQuery() => _instanceUserQuery;

        public IQuestionnaireQuery GetInstanceQuestionnaireQuery() => _instanceQuestionnaireQuery;


        public IArticleRepository GetInstanceArticleRepository() => _instanceArticleRepository;

        public ICommentRepository GetInstanceCommentRepository() => _instanceCommentRepository;

        public IUserRepositiory GetInstanceUserRepository() => _instanceUserRepositiory;

        public IWebBlogRatingRepository GetInstanceWebBlogRatingRepository() => _instanceWebBlogRatingRepository;
    }
}