using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBlog.Contracts.QueryRepositories;
using WebBlog.Models.Entity.QuestionnaireComponents;
using System.Data.Entity;


namespace WebBlog.DB.QueryRepositories
{
    public class QuestionnaireQuery: IQuestionnaireQuery
    {
        private readonly MyDbContext _context;

        public QuestionnaireQuery(MyDbContext context) => _context = context;

        public Questionnaire GetQuestionnaireByTitle(string title)
        {
            var questionnaire = GetQuery().FirstOrDefault(x => x.Title == title);
           //sort by cost 
            return questionnaire;
        }

        public Questionnaire GetById(Guid id)
        {
            var questionnaire = GetQuery().FirstOrDefault(x => x.Id == id);
            return questionnaire;
        }

        public IEnumerable<Answer> GetAllAnswersForQuestionnaire(Guid questionnaireId)
        {
            var questionnaire = GetQuery().FirstOrDefault(x => x.Id == questionnaireId);

            var answers = new List<Answer>();

            questionnaire.Questions.ToList().ForEach(x => answers.AddRange(x.Answer));

            return answers;
          
        }

        private IQueryable<Questionnaire> GetQuery()
            => _context.Set<Questionnaire>().Include(x=>x.Questions.Select(a=>a.Answer));
    }
}