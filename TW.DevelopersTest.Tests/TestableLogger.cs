using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TW.DeveloperTest.Contracts;

namespace TW.DeveloperTest.Tests
{
    internal class TestableLogger : ILogger
    {
        List<LogEntry> _LogEntries = new List<LogEntry>();

        public void Log(LogLevel level, string tag, string message)
        {
            var logEntry = new LogEntry
            {
                TimeStamp = DateTime.Now,
                Level = level,
                Tag = tag,
                Message = message
            };
            _LogEntries.Add(logEntry);
        }

        public void LogException(Exception e, string tag)
        {
            Log(LogLevel.Error, tag, e.Message);
        }

        public LogEntry GetLastLogEntry()
        {
            return _LogEntries.LastOrDefault();
        }

    }
}
