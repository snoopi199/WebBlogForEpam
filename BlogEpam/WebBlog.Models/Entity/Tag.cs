using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebBlog.Models.Entity
{
    public class Tag
    {
        [Key]
        public string Signature { get; set; }

        public ICollection<Article> Articles { get; set; }

        public Tag()
        {
            Articles = new List<Article>();
        }


    }
}