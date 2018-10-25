using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBlog.Models.Entity;

namespace WebBlog.Contracts.QueryRepositories
{

    public interface IArticleQuery
    {
        Article Get(Guid id);

        IEnumerable<Article> GetAll();

        IEnumerable<Article> GetByAuthor(Guid authorId);
    }
}