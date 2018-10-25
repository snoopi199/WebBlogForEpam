using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBlog.Contracts.QueryRepositories;
using WebBlog.Models.Entity;

namespace WebBlog.Services
{
    public  class ProviderArticleQuery
    {
        IArticleQuery articleQuery;
        public ProviderArticleQuery(IArticleQuery articleQuery)
        {
            this.articleQuery = articleQuery;
        }
        public IEnumerable<Article> GetAllArticles()
        {
            return articleQuery.GetAll();
        }
        public Article GetArticle(Guid id)
        {
            return articleQuery.Get(id);
        }
        

    }
}