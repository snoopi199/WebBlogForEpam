using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBlog.Contracts.QueryRepositories;
using WebBlog.Contracts.Repositories;
using WebBlog.Models.Entity;

namespace WebBlog.Services
{
    public class ProviderCommentQuery
    {

        ICommentQuery commentQuery;
        ICommentRepository commentRepository;

        IUserRepositiory userRepositiory;
        IUserQuery userQuery;
        

        public ProviderCommentQuery(ICommentQuery commentQuery, ICommentRepository commentRepository,
           IUserQuery userQuery, IUserRepositiory userRepositiory)
        {
            this.commentQuery = commentQuery;
            this.commentRepository = commentRepository;
            this.userQuery = userQuery;
            this.userRepositiory = userRepositiory;
        }

        public IEnumerable<Comment> GetCommentsByType(string type)
        {
            return commentQuery.GetByType(type).OrderByDescending(x=>x.Date);
        }

        //commented
        public void AddCommentForGuestPage(string email, string name, DateTime date, string text)
        {
            var user = new User
            {
                Id = Guid.NewGuid(),
                Email = email,
                Name = name,
            };
            userRepositiory.Add(user);
            
            var comment = new Comment
            {
                Id = Guid.NewGuid(),
                Date = date,
                Type = "GuestPage",
                UserId = user.Id,
                Text = text
            };
            commentRepository.Add(comment);
        }

        public void AddComent(Comment comment) => commentRepository.Add(comment);
        
    }
}