﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeLogCreator
{
    internal class Log
    {
        public string Version { get; set; }
        public DateTime LogTime { get; set; }
        public List<LogItem> Logs { get; set; }


    }
}
