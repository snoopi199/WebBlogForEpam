using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBlog.Models.Entity
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; } 

        public ICollection<Article> Articles { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public User()
        {
            Comments = new List<Comment>();
            Articles = new List<Article>();
        }
    }
}