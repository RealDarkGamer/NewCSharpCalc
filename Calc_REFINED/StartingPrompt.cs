using System;
using System.Collections.Generic;
using System.Text;

namespace Calc_REFINED
{
    class StartingPrompt
    {
        public static void Prompt(string Vers_Num, string equation, bool IsDev, string path, string path_dev, string path_def, string User)
        {
            //Check if the user is a developer. If not, continue.
            if (IsDev == true)
            {
                DeveloperUser.PromptDev(Vers_Num, equation, path_dev, User);
            }
            //Check if the equation is null.
            if (equation == null)
            {
                Console.WriteLine("Welcome to CSharp Calc " + Vers_Num + "! Please enter an equation like this: 3 * 4 / 2 \n");
                equation = Console.ReadLine();
                //If equation input was "dev", run the Dev Prompt. If not, continue.
                if (equation.ToLower() == "dev")
                {
                    IsDev = true;
                    DeveloperUser.PromptDev(Vers_Num, equation, path_dev, User);
                }
                else
                {
                    DefaultUser.PromptDef(Vers_Num, equation, path_def, User);
                }
            }
        }
    }
}
