﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBlog.Entitys
{
    public class Article
    {
        public Article()
        {
            Comments = new List<Comment>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public Author Author { get; set; }
        ICollection<Comment> Comments { get; set; }
    }
}