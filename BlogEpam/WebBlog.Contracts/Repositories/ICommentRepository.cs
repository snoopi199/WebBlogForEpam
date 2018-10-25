using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBlog.Models.Entity;

namespace WebBlog.Contracts.Repositories
{
    public interface ICommentRepository
    {
        void Add(Comment comment);
        void AddRange(IEnumerable<Comment> comments);
        void Remove(Comment comment);
        void RemoveRange(IEnumerable<Comment> comments);

    }
}
