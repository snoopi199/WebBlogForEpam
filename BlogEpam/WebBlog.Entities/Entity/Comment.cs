using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBlog.Entitys
{
    public class Comment
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public Author Author { get; set; }
    }
}