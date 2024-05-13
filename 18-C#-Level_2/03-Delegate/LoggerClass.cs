using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Delegate
{
    public class Logger
    {
        // delegate
        public delegate void LogAction(string Message);

        private LogAction _LogAction;

        public Logger(LogAction logAction)
        {
            _LogAction = logAction;
        }

        public void Log(string Message)
        {
            _LogAction(Message);
        }
    }

    
    internal class LoggerClass
    {
        public static void LogToScreen(string Message)
        {
            Console.WriteLine("From LogToScreen : " + Message);
        } 
        public static void LogToFile(string Message)
        {
            using (StreamWriter Writer = new StreamWriter("file.txt", true))
            {
                Writer.WriteLine("From LogToScreen : " + Message);
            }
        }
        //static void Main(string[] args)
        //{
        //    Logger ScreenLog = new Logger(LogToScreen);
        //    Logger FileLog = new Logger(LogToFile);
        //
        //    ScreenLog.Log("Hello C# Level 2 . Delegation is Awosme");
        //    FileLog.Log("Hello C# Level 2 . Delegation is Awosme");
        //}
    }
}
