using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBlog.Models.Entity;

namespace WebBlog.Contracts.QueryRepositories
{
    public interface ICommentQuery
    {
        Comment Get(Guid id);
        IEnumerable<Comment> GetByType(string type);
    }
}
