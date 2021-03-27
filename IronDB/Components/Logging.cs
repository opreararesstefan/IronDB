using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronDB.Components
{
    class Logging
    {
  
        #region Properties

        public const string LOGS = @"C:\temp\Logs.txt";

        #endregion

        #region Logging

        public static void StartLogs()
        {
            var LOGS = @"C:\temp\Logs.txt";
            if (File.Exists(LOGS))
                File.Delete(LOGS);
        }


        /// <summary>
        /// ReportLogsInfo
        /// </summary>
        /// <param name="strMessage">strMessage</param>
        public static void ReportLogsInfo(string strMessage)
        {
            using (StreamWriter w = File.AppendText(LOGS))
            {
                WriteToLogs(strMessage, w);
            }
        }

        private static void WriteToLogs(string strMessage, TextWriter w)
        {
            w.Write("\r\nLog Info : ");
            w.WriteLine($"  :{strMessage}");
            w.WriteLine("-------------------------------");
        }

        #endregion
    }
}
