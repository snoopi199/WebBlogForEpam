using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBlog.Models.Entity
{
    public class Article
    {
        public Article()
        {
            Comments = new List<Comment>();
            Tags = new List<Tag>();
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public ICollection<Tag> Tags { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}