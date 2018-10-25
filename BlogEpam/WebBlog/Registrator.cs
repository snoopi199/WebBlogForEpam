using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBlog.CR;

namespace WebBlog
{
    public class Registrator : NinjectModule
    {
        public override void Load()
        {
            Bind<ICreatorOfInctances>().To<CreatorOfInctances>();
        }
    
    }
}