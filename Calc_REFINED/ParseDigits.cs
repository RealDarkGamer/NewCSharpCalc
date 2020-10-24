using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace Calc_REFINED
{
    class ParseDigits
    {
        public static void Parse(string equation)
        {
            Console.WriteLine("Parsing");
            string operators = "+-*/%.^ ";
            foreach (char charfp in equation)
            {
                try
                {
                    string stringfp = Convert.ToString(charfp);
                    if (double.TryParse(stringfp, out double numdigit))
                    {
                    }
                    else
                    {
                        if (!operators.Contains(stringfp))
                        {
                            Console.WriteLine(stringfp + " is not valid. Please try again.");
                            PROGRAM_START.Main();
                        }
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("Could not access file. Try running as an administrator.");
                }
            }
            Calculation.ComputeEQ(equation);
        }
    }
}
