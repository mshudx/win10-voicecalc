using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoiceCalc.Windows.Models
{
    public class Operation
    {
        public string RawText { get; set; }
        public string CommandName { get; set; }
        public string Parameter1 { get; set; }
        public string Parameter2 { get; set; }
    }
}
