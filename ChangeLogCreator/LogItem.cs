using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeLogCreator
{
    internal class LogItem
    {
        public string GroupName { get; set; }
        public LogType ItemType { get; set; }
        public string LogMessage { get; set; }
    }
}
