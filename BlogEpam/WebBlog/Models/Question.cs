using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBlog.Models
{
    public class Question
    {
        static int count = 0;
       
        public string Name { get; set; }
        public string Title { get; set; }


        public string Type { get; set; }

        private ICollection<int> checkeds;

        public ICollection<int> Chekeds
        {
            get { return checkeds; }
            set { checkeds = value; }
        }

        private ICollection<Answer> answers;       

        public ICollection<Answer> Answers
        {
            get { return answers; }
            set { answers = value; }
        }
        public Question(string question, string type, Answer[] answers)
        {
            Name = "question" + count;
            count++;
            Title = question;
            Type = type;
            this.answers = new List<Answer>();
            AddAnswers(answers);
            checkeds = new List<int>();
        }

        private void AddAnswers(Answer[] answers)
        {
            foreach (var item in answers)
            {
                Answers.Add(item);
            }
        }
    }
}