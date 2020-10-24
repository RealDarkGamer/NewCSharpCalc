using System;
using System.Text;
using System.IO;
using System.Linq.Expressions;

namespace Calc_REFINED
{
    class DeveloperUser
    {
        public static void PromptDev(string Vers_Num, string equation, string FilePath, string User)
        {
            Console.Clear();
            equation = null;
            Console.WriteLine("Welcome to CSharp Calc " + Vers_Num + "! Please enter an equation like this: 3 * 4 / 2 \n");
            equation = Console.ReadLine();
            //Put the equation into a char array
            char[] eq;
            eq = equation.ToCharArray(0, equation.Length);
            //Make the equation file
            try
            {
                using (FileStream fs_Dev = File.Create(FilePath + "\\PDEV_EQ.TXT"))
                {
                    //for each character in the array, write it to the equation file.
                    foreach (char ch in eq)
                    {
                        byte[] devfileinfo = new UTF8Encoding(true).GetBytes(ch + "\n");
                        fs_Dev.Write(devfileinfo, 0, devfileinfo.Length);
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("UnauthorizedAccessException: Could not access file. \nTry running the program as an administrator.");
            }
            ParseDigits.Parse(equation);
        }
    }
}
