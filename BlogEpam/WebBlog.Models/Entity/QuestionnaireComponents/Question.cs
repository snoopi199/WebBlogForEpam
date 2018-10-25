using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBlog.Models.Entity.QuestionnaireComponents
{
    public class Question
    {
        public Guid Id { get; set; }

        public string Type { get; set; }

        public string Title { get; set; }

        public ICollection<Answer> Answer { get; set; }

        public Question()
        {
            Answer = new List<Answer>();
        }

    }
}