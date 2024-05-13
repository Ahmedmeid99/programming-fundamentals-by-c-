using System;
using System.Diagnostics;
using System.Configuration;

namespace _08_Event_Log_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ---------------------------------------
            // ----[Event Log (from Event Viewer)]----
            // ---------------------------------------

            string SourceName = "DVLD_Application";// Application Name

            if(!EventLog.SourceExists(SourceName))
            {
                EventLog.CreateEventSource(SourceName, "Application");

                EventLog.WriteEntry(SourceName, "Message Information", EventLogEntryType.Information);
                EventLog.WriteEntry(SourceName, "Message Warning", EventLogEntryType.Warning);
                EventLog.WriteEntry(SourceName, "Message Error", EventLogEntryType.Error);
            }

            // ---------------------------------------
            // -----[Convigration (App.config)]-------
            // ---------------------------------------

            // [1] save configration in appsettings
            //string ConfigString = ConfigurationManager.AppSettings["ConnectionString"];

            // [2] create new tag and save configration in it
            string ConfigString2 = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;


            //Console.WriteLine("ConnectionString 1 : " + ConfigString);
            Console.WriteLine("ConnectionString 2 : " + ConfigString2);

            Console.ReadKey();

        }
    }
}
