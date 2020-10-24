using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Calc_REFINED
{
    class Calculation
    {
        public static void ComputeEQ(string equation)
        {
            string formula = equation;
            StringToFormula stf = new StringToFormula();
            double result = stf.Eval(formula);
            Console.WriteLine("Result: " + result);
            RunFuncAgain();
        }

        static void RunFuncAgain()
        {
            Console.WriteLine("Solve another equation? Y/N");
            string Response = Console.ReadLine().ToLower();
            if (Response == "y")
            {
                PROGRAM_START.Main();
            }
            else if (Response == "n")
            {
                Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Response was not Y or N");
            }
        }
    }
}
