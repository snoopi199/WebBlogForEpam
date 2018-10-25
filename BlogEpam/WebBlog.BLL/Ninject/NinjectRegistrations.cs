using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using WebBlog.DAL.Core;
using WebBlog.DAL.Persistence;


namespace WebBlog.BLL.Ninject
{
    public class NinjectRegistrations: NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>();
        }
    }
}