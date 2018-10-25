using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebBlog.Entities.Entity.InputTypeForQuestionnaire;

namespace WebBlog.Entitys
{
    public class Questionnaire
    {
        public Questionnaire()
        {
            CheckBoxes = new List<CheckBox>();
            RadioButtons = new List<RadioButton>();
            TextBoxes = new List<TextBox>();
            TextAreas = new List<TextArea>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<CheckBox> CheckBoxes { get; set; }
        public ICollection<RadioButton> RadioButtons { get; set; }
        public ICollection<TextBox> TextBoxes { get; set; }
        public ICollection<TextArea> TextAreas { get; set; }
    }
}