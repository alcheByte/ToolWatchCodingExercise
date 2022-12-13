using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TW.DeveloperTest.Contracts
{
    public interface ILogger
    {
        void Log(LogLevel level, string tag, string message);
        void LogException(Exception e, string tag);
        LogEntry GetLastLogEntry();
    }
}
