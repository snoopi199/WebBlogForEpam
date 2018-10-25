using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBlog.Models.Entity;

namespace WebBlog.Contracts.Repositories
{
    public interface IUserRepositiory
    {
        void Add(User user);
        void Remove(User user);
    }
}
