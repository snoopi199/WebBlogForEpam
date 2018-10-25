using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBlog.Entities.Entity.InputTypeForQuestionnaire;

namespace WebBlog.Entities.Entity.InputTypeForQuestionnaire
{
    public class RadioButton : BaseInputType
    {
        public RadioButton()
        {
            VariantsOfAnswers = new List<Answer>();
        }
        public ICollection<Answer> VariantsOfAnswers { get; set; }
        //public int RightAnswer { get; set; }
    }
}