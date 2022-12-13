using System;
using System.Threading;
using TW.DeveloperTest.Contracts;

namespace TW.DeveloperTest.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            ILogger logger = Ioc.Resolve<ILogger>();
            IWorker worker = Ioc.Resolve<IWorker>();

            do
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();

                    if (key.Modifiers.HasFlag(ConsoleModifiers.Control)
                        && key.Key == ConsoleKey.X)
                    {
                        run = false;
                    }
                }

                try
                {
                    var result = worker.GetResult();

                    logger.Log(LogLevel.Debug, "Program.Main", $"output - {result}");
                }
                catch (Exception e)
                {
                    logger.LogException(e, "Program.Main");
                }
                
                Thread.Sleep(500);
            } while (run);
        }
    }
}
