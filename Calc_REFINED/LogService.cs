using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Calc_REFINED
{
    class LogService
    {
        public static void MakeLog(string logpath)
        {
            using (FileStream fs_log = File.Create(logpath + "\\LOG.TXT"))
            {
                byte[] PSDATAMainLog = new UTF8Encoding(true).GetBytes("");
                fs_log.Write(PSDATAMainLog, 0, PSDATAMainLog.Length);
            }
        }
        public static void makeProgramFiles(byte[] info, string path)
        {
            using (FileStream fs_program = File.Create(path))
            {
                fs_program.Write(info, 0, info.Length);
            }
        }
    }
}
