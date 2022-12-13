using Ninject;
using Ninject.Modules;
using TW.DeveloperTest.Contracts;
using TW.DeveloperTest.WorkLibrary;

namespace TW.DeveloperTest.Tests
{
    [TestClass]
    public class UnitTestModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILogger>().To<TestableLogger>();
        }

        [TestMethod]
        public void TestLogLevelOutput()
        {
            ILogger logger = Ioc.Resolve<ILogger>();

            logger.Log(LogLevel.Debug, "TEST_Debug", "This is a debug log entry.");
            var entry = logger.GetLastLogEntry();
            Assert.AreEqual(entry.Level, LogLevel.Debug);
            Assert.IsTrue(entry.Tag == "TEST_Debug");

            logger.Log(LogLevel.Info, "TEST_Info", "This is a information log entry.");
            entry = logger.GetLastLogEntry();
            Assert.AreEqual(entry.Level, LogLevel.Info);
            Assert.IsTrue(entry.Tag == "TEST_Info");

            logger.Log(LogLevel.Warning, "TEST_Warning", "This is a warning log entry.");
            entry = logger.GetLastLogEntry();
            Assert.AreEqual(entry.Level, LogLevel.Warning);
            Assert.IsTrue(entry.Tag == "TEST_Warning");

            logger.Log(LogLevel.Error, "TEST_Error", "This is a error log entry.");
            entry = logger.GetLastLogEntry();
            Assert.AreEqual(entry.Level, LogLevel.Error);
            Assert.IsTrue(entry.Tag == "TEST_Error");
        }
    }
}