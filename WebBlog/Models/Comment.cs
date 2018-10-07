using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBlog.Models
{
    public class Comment
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public Comment(string name, DateTime date, string text)
        {
            Name = name;
            Date = date;
            Text = text;
        }
    }
}