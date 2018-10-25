using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBlog.DAL.Core;
using WebBlog.DAL.Core.Repositories;
using WebBlog.DAL.Persistence.Repositories;

namespace WebBlog.DAL.Persistence
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly BlogContext _context;

        public UnitOfWork(BlogContext context)
        {
            _context = context;
            Articles = new ArticleRepository(_context);
            Comments = new CommentRepository(_context);
            Questionnaires = new QuestionnaireRepository(_context);
        }

        public IArticleRepository Articles{ get; private set; }
        public ICommentRepository Comments { get; private set; }
        public IQuestionnaireRepository Questionnaires { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}