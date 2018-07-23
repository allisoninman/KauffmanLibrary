using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KauffmanLibrary.Models
{
    public class LogEntry
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public bool IsCheckingOut { get; set; }
    }
}
