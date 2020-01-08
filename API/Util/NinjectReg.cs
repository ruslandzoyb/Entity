using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using BL.Services;
using BL.ServiceInterfaces;
namespace API.Util
{
    public class NinjectReg:NinjectModule
    {
        public NinjectReg()
        {

        }

        public override void Load()
        {
            Bind<IServices>().To<Services>();
        }
    }
}