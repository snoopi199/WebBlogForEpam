using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBlog.Models.Entity.QuestionnaireComponents
{
    public class Questionnaire
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public ICollection<Question> Questions { get; set; }

        public Questionnaire()
        {
            Questions = new List<Question>();
        }

    }
}