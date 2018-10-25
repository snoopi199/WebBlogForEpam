using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebBlog.DAL.Core.Repositories;
using WebBlog.Entitys;

namespace WebBlog.DAL.Persistence.Repositories
{
    public class ArticleRepository : Repository<Article>, IArticleRepository
    {
        public ArticleRepository(BlogContext context) : base(context)
        {

        }
        public BlogContext BlogContext
        {
            get { return Context as BlogContext; }
        }
    }
}