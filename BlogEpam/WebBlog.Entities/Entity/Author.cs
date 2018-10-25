using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace WebBlog.Entitys
{
    public class Author
    {
        public Author()
        {
            Comments = new List<Comment>();
            Articles = new List<Article>();
        }

        [Key]
        public string Email { get; set; }
        public string Name { get; set; }
        public ICollection<Article> Articles { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}