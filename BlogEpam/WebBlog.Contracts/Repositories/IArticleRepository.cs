using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBlog.Models.Entity;

namespace WebBlog.Contracts.Repositories
{
    public interface IArticleRepository
    {
        void Add(Article article);
        void Remove(Article article);
    }
}
