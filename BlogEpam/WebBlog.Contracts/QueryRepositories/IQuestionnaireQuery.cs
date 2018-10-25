using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBlog.Models.Entity.QuestionnaireComponents;

namespace WebBlog.Contracts.QueryRepositories
{
    public interface IQuestionnaireQuery
    {
        Questionnaire GetQuestionnaireByTitle(string title);
    }
}
