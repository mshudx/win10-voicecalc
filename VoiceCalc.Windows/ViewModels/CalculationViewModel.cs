using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoiceCalc.Windows.Models;

namespace VoiceCalc.Windows.ViewModels
{
    public class CalculationViewModel
    {
        public Operation Operation { get; set; }
        public string Result
        {
            get
            {
                return CalculationEngine.Calculate(Operation);
            }
        }
    }
}
