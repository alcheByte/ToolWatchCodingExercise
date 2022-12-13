using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TW.DeveloperTest.Contracts;

namespace TW.DeveloperTest.WorkLibrary
{
    public class ConsoleLogger : ILogger
    {
        string Timestamp(DateTime date)
        {
            return string.Format("{0}{1:D4}", date.ToString("yyyyMMddHHmmss"), date.Millisecond);
        }

        public void Log(LogLevel level, string tag, string message)
        {
            var colorPrevious = Console.ForegroundColor;
            switch (level)
            {
                case LogLevel.Debug:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case LogLevel.Info:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case LogLevel.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case LogLevel.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{Timestamp(DateTime.Now)}|{level}|{message}");
            Console.ForegroundColor = colorPrevious;
        }

        public void LogException(Exception e, string tag)
        {
            Log(LogLevel.Error, tag, e.Message);
        }

        public LogEntry GetLastLogEntry()
        {
            return null;
        }
    }
}
