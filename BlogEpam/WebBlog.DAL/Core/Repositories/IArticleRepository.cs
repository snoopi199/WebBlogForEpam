using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBlog.Entitys;

namespace WebBlog.DAL.Core.Repositories
{
    public interface IArticleRepository:IRepository<Article>
    {
    }
}