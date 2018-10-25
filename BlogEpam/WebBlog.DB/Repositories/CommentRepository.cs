using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBlog.Contracts.Repositories;
using WebBlog.Models.Entity;

namespace WebBlog.DB.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly MyDbContext _context;

        public CommentRepository(MyDbContext context) => _context = context;

        public void Add(Comment comment)
        {
            _context.Comments.Add(comment);
            _context.SaveChanges();
        }

        public void AddRange(IEnumerable<Comment> comments)
        {
            _context.Comments.AddRange(comments);
            _context.SaveChanges();
        }

        public void Remove(Comment comment)
        {
            _context.Comments.Remove(comment);
            _context.SaveChanges();
        }
        public void RemoveRange(IEnumerable<Comment> comments)
        {
            _context.Comments.RemoveRange(comments);
            _context.SaveChanges();
        }
    }
}