using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBlog.Models.Entity
{
    public class WebBlogRating
    {
        public Guid Id { get; set; }
        public byte Mark { get; set; }
        public DateTime Date { get; set; }
        public string Suggestion { get; set; }
    }
}