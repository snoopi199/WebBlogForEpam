using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBlog.Models
{
    public class Answer
    {
        public string AnswerName { get; set; }

        public int Cost { get; set; }

        public Answer(string answer, int cost)
        {
            AnswerName = answer;
            Cost = cost;
        }

    }
}