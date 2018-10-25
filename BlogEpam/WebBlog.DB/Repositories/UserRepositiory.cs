using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBlog.Contracts.Repositories;
using WebBlog.Models.Entity;

namespace WebBlog.DB.Repositories
{
    public class UserRepositiory : IUserRepositiory
    {
        private readonly MyDbContext _context;

        public UserRepositiory(MyDbContext context) => _context = context;
        
        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Remove(User user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
    }
}