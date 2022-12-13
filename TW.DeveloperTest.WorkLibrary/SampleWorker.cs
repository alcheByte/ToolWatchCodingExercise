using System;
using System.Text;
using TW.DeveloperTest.Contracts;

namespace TW.DeveloperTest.WorkLibrary
{
    public class SampleWorker : IWorker
    {
        readonly Random _random;
        private ILogger _Logger;

        public SampleWorker(ILogger logger)
        {
            _Logger = logger;
            _random = new Random();
        }

        public string GetResult()
        {
            int result = _random.Next(0, 100);

            if (result <= 95)
            {
                var output = RandomString(result);
                if(result < 10)
                    _Logger.Log(LogLevel.Warning, "SampleWorker.GetResult", output);
                else
                    _Logger.Log(LogLevel.Info, "SampleWorker.GetResult", output);
                return output;
            }

            throw new Exception($"Out of range exception - {result} > 95");
        }

        private string RandomString(int length)
        {
            const string pool = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var builder = new StringBuilder();

            for (var i = 0; i < length; i++)
            {
                var c = pool[_random.Next(0, pool.Length)];
                builder.Append(c);
            }

            return builder.ToString();
        }
    }
}
