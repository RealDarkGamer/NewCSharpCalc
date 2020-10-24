using System;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace Calc_REFINED
{
    class PSData
    {
        public static void FirstTimeSetup(string User)
        {
            //Specify Specific Path.
            string path = "C:\\Users\\" + User + "\\Calc_REFINED";
            string path_def = path + "\\U_DEFAULT";
            string path_dev = path + "\\U_DEVELOPER";
            string path_log = path + "\\Logs";
            string programFiles = path + "\\program_files";
            string psdata = programFiles + "\\PSData.TXT";
            //Create directory if user doesn't have them
            Directory.CreateDirectory(path);
            Directory.CreateDirectory(path_def);
            Directory.CreateDirectory(path_dev);
            Directory.CreateDirectory(path_log);
            Directory.CreateDirectory(programFiles);

            //Tell the user where the log is located if they haven't seen the notice.
            string[] fileLines = new string[1];

            using (StreamReader SRpF = File.OpenText(psdata))
            {
                int x = 0;
                while (!SRpF.EndOfStream)
                {
                    fileLines[x] = SRpF.ReadLine();
                    x += 1;
                }
            }

            Parallel.For(0, fileLines.Length, x =>
            {
                if (fileLines[0] != "logNotice: seen")
                {
                    Console.WriteLine("Log made at " + path_log + "\\LOG.TXT. Press any key to continue. \n ");
                    Console.ReadKey();
                    Console.Clear();
                    LogService.makeProgramFiles(new UTF8Encoding(true).GetBytes("logNotice: seen"), psdata);
                }
            });
            //Make LOG.TXT file
            LogService.MakeLog(path_log);
            //Sets paramaters
            bool IsDev = false;
            string Vers_Num = "V 1.0.Test_1";
            Console.Title = "CSharp Calc_REFINED " + Vers_Num + " | ";
            StartingPrompt.Prompt(Vers_Num, null, IsDev, path, path_dev, path_def, User);
        }
    }
}
