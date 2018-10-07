using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBlog.Models
{
    public enum QustionaryType:byte
    {
        checkbox,
        radiobutton
    }

    public class Question
    {
        public string QuestionName { get; set; }

        public byte Type { get; set; }

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
        public Question(string question, QustionaryType type, Answer[] answers)
        {
            QuestionName = question;
            Type = (byte)type;
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