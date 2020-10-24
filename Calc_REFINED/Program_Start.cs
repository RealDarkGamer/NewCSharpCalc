using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Calc_REFINED
{
    class PROGRAM_START
    {
        public static void Main()
        {
            //Get the Username of the person who ran the program
            string User = Environment.UserName;
            //Testfile Location
            string TestFile = "C:\\Users\\" + User + "\\Calc_REFINED\\DummyFile";
            //Run setup if it is users first time.
            if (!File.Exists(TestFile))
            {
                Console.WriteLine("Running First Time Setup...");
                PSData.FirstTimeSetup(User);
                Console.Clear();
            }
        }
    }
}
