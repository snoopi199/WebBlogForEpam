using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBlog.Contracts.QueryRepositories;
using WebBlog.Models.Entity;
using System.Data.Entity;


namespace WebBlog.DB.QueryRepositories
{
    public class ArticleQuery : IArticleQuery
    {
        private readonly MyDbContext _context;

        public ArticleQuery(MyDbContext context) => _context = context;

        public Article Get(Guid id)
            => GetQuery().FirstOrDefault(article => article.Id == id);

        public IEnumerable<Article> GetAll()
            => GetQuery();

        public IEnumerable<Article> GetByAuthor(Guid authorId)
             => GetQuery().Where(article => article.UserId == authorId);

        private IQueryable<Article> GetQuery()
            => _context.Set<Article>().Include(x => x.User);
    }
}