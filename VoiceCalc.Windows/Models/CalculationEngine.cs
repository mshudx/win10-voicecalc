using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoiceCalc.Windows.Models
{
    public static class CalculationEngine
    {
        public static string Calculate(Operation operation)
        {
            if (operation == null)
            {
                return "Error: operation is null";
            }
            else
            {
                try
                {
                    var parameter1 = double.Parse(operation.Parameter1);
                    var parameter2 = double.Parse(operation.Parameter2);

                    switch (operation.CommandName)
                    {
                        case "operationAdd":
                            return (parameter1 + parameter2).ToString();
                        case "operationMultiply":
                            return (parameter1 * parameter2).ToString();
                        default:
                            return $"Error: unknown command ({operation.CommandName}";
                    }
                }
                catch (Exception ex)
                {
                    return $"Error: execution failed {ex.Message}";
                }
            }
        }
    }
}
