using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBlog.Contracts.QueryRepositories;
using WebBlog.Models.Entity;
using System.Data.Entity;


namespace WebBlog.DB.QueryRepositories
{
    public class UserQuery:IUserQuery
    {
        private readonly MyDbContext _context;

        public UserQuery(MyDbContext context) => _context = context;

        public User Get(Guid id)
            => GetQuery().FirstOrDefault(user => user.Id == id);

        public bool ContainsEmail(string email)
        {
            var user = GetQuery().FirstOrDefault(x => x.Email == email);
            if (user == null) return false;
            return true;
        }
        private IQueryable<User> GetQuery()
            => _context.Set<User>().Include(x => x.Articles)
            .Include(x => x.Comments);
    }
}