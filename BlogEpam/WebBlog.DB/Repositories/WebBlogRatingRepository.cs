using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBlog.Contracts.Repositories;
using WebBlog.Models.Entity;

namespace WebBlog.DB.Repositories
{
    public class WebBlogRatingRepository : IWebBlogRatingRepository
    {
        private readonly MyDbContext _context;
        public WebBlogRatingRepository(MyDbContext context) => _context = context;
        public void Add(WebBlogRating rating)
        {
            _context.WebBlogRating.Add(rating);
            _context.SaveChanges();
        }
    }
}