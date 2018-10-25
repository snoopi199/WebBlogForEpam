using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBlog.Entities.Entity.InputTypeForQuestionnaire;

namespace WebBlog.Entities.Entity.InputTypeForQuestionnaire
{
    public class CheckBox : BaseInputType
    {
        public CheckBox()
        {
            VariantsOfAnswers = new List<Answer>();          
        }
        public ICollection<Answer> VariantsOfAnswers { get; set; }
        //ICollection<int> RightAnswers { get; set; }      
    }
}