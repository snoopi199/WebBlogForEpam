using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBlog.Models.Entity;
using System.Data.Entity;
using WebBlog.Contracts.QueryRepositories;

namespace WebBlog.DB.QueryRepositories
{
    public class CommentQuery:ICommentQuery
    {
        private readonly MyDbContext _context;

        public CommentQuery(MyDbContext context)=>_context = context;

        public Comment Get(Guid id) => GetQuery().FirstOrDefault(x => x.Id == id);

        public IEnumerable<Comment> GetByType(string type)
            => GetQuery().Where(x => x.Type == type);

        private IQueryable<Comment> GetQuery()
            =>_context.Set<Comment>().Include(x => x.Users);

     


    }
}