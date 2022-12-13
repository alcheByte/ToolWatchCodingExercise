using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TW.DeveloperTest.Contracts
{
    public class LogEntry
    {
        public DateTime TimeStamp { get; set; }
        public LogLevel Level { get; set; }
        public string Message { get; set; }
        public string Tag { get; set; }
    }
}
