using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBlog.Models.Entity;

namespace WebBlog.Contracts.Repositories
{
    public interface IWebBlogRatingRepository
    {
        void Add(WebBlogRating rating);
    }
}
