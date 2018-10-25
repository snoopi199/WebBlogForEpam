using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBlog.Contracts.Repositories;
using WebBlog.Models.Entity;

namespace WebBlog.DB.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        public void Add(Article article)
        {
            throw new NotImplementedException();
        }

        public void Remove(Article article)
        {
            throw new NotImplementedException();
        }
    }
}