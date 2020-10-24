using System;
using System.Text;
using System.IO;

namespace Calc_REFINED
{
    class DefaultUser
    {
        public static void PromptDef(string Vers_Num, string equation, string FilePath, string User)
        {
            //Put the equation into a char array
            char[] eq;
            eq = equation.ToCharArray(0, equation.Length);
            //Make the equation file
            try
            {
                using (FileStream fs_Dev = File.Create(FilePath + "\\PDEF_EQ.TXT"))
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
