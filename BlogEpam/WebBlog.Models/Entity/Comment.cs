using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBlog.Models.Entity
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }

        public Guid UserId { get; set; }
        public User Users { get; set; }

        public ICollection<Article> Articles { get; set; }

        public Comment()
        {
            Articles = new List<Article>();
        }

    }
}