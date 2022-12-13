using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;

namespace TW.DeveloperTest.ConsoleApp
{
    public static class Ioc
    {
        static IKernel _kernel;

        public static T Resolve<T>()
        {
            if (_kernel == null)
            {
                _kernel = CreateKernel();
            }

            return _kernel.Get<T>();
        }

        static IKernel CreateKernel()
        {
            IEnumerable<NinjectModule> modules = new List<NinjectModule>
            {
                new DeveloperTestModule()
            };

            return new StandardKernel(modules.ToArray());
        }
    }
}
