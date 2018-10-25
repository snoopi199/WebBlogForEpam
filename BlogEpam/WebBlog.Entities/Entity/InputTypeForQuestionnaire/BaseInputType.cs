using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBlog.Entities.Entity.InputTypeForQuestionnaire
{ 

    public abstract class BaseInputType
    {
        public int Number { get; set; }
        public string Question { get; set; }
    }
}