using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

using WebBlog.Entities.Entity.InputTypeForQuestionnaire;
using WebBlog.Entitys;

namespace WebBlog.DAL.Persistence
{
    public class BlogContext : DbContext
    {
        public BlogContext()
            : base("BlogContext")//: base("name=BlogContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Questionnaire> Questionnaires { get; set; }
        public virtual DbSet<Author> Authors { get; set; }

        
        
    }
}