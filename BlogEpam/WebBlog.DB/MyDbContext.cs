using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using WebBlog.Models.Entity;
using WebBlog.Models.Entity.QuestionnaireComponents;

namespace WebBlog.DB
{
    public class MyDbContext:DbContext
    {
        static MyDbContext()
        {
            Database.SetInitializer<MyDbContext>(new BlogDbInitializer());
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Questionnaire> Questionnaires { get; set; }
        public DbSet<WebBlogRating> WebBlogRating { get; set; }
        public DbSet<Answer> Answers { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
       
            modelBuilder.Entity<Comment>().HasMany(c => c.Articles)
                .WithMany(s => s.Comments)
                .Map(t => t.MapLeftKey("CommentId")
                .MapRightKey("ArticleId")
                .ToTable("CommentArticle"));

            modelBuilder.Entity<Tag>().HasMany(c => c.Articles)
                .WithMany(s => s.Tags)
                .Map(t => t.MapLeftKey("TagId")
                .MapRightKey("ArticleId")
                .ToTable("TagArticle"));
        }
    }
}