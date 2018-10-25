using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace WebBlog.DAL.Core.Repositories
{
    public interface IRepository<TEnity>where TEnity:class
    {
        TEnity Get(int id);
        IEnumerable<TEnity> GetAll();
        IEnumerable<TEnity> Find(Expression<Func<TEnity, bool>> predicate);

        void Add(TEnity enity);
        void AddRange(IEnumerable<TEnity> entity);

        void Remove(TEnity enity);    
        void RemoveRange(IEnumerable<TEnity> enity);
    }
}