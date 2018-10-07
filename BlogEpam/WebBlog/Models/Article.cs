using System;
using System.Collections.Generic;

namespace WebBlog.Models
{
    public class Article
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public Article(string title, DateTime date, string text)
        {
            Title = title;
            Date = date;
            Text = text;
        }
    }

   
}