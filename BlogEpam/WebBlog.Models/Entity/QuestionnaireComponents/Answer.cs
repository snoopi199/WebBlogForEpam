using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBlog.Models.Entity.QuestionnaireComponents
{
    public class Answer
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public int Cost { get; set; }
    }
}