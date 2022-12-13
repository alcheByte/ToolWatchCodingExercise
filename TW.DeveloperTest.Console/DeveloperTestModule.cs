using Ninject.Modules;
using TW.DeveloperTest.Contracts;
using TW.DeveloperTest.WorkLibrary;

namespace TW.DeveloperTest.ConsoleApp
{
    public class DeveloperTestModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IWorker>().To<SampleWorker>();
        }
    }
}
