using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBlog.DAL.Core.Repositories;

namespace WebBlog.DAL.Core
{
    public interface IUnitOfWork:IDisposable
    {
        IArticleRepository Articles { get; } 
        ICommentRepository Comments { get; }
        IQuestionnaireRepository Questionnaires { get; }
        int Complete();
    }
      
}