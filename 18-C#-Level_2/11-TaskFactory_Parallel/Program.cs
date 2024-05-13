using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _11_TaskFactory_Parallel
{
    internal class Program
    {
        static void Download(string url)
        {
            string webContent;
            using(WebClient content = new WebClient())
            {
                webContent = content.DownloadString(url);
            }
            Console.WriteLine($"url content count : {webContent.Length}");
        }
        static void Main(string[] args)
        {
            // ather ways to use multithreading
            // 1 - Task.Run()
            // 2 - Parallel
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
           
            Task.Run(() =>
            {
                Task.Delay(400);
                Console.WriteLine("MultiThread Task 1");
            }
            ); 
            
            Task.Run(() =>
            {
                Task.Delay(400);
                Console.WriteLine("MultiThread Task 2");
            });

            stopwatch.Stop();

            
            Task.WaitAll();
            Console.WriteLine("Task.Run => " + stopwatch.ElapsedMilliseconds);

            // --------------------------------
            // ----------[Parallel]------------
            // --------------------------------

            Stopwatch stopwatch2 = new Stopwatch();

            stopwatch2.Start();
           
            Parallel.Invoke(
                () =>
                {
                    Task.Delay(400);
                    Console.WriteLine("MultiThread Task 1");
                },
                () => {
                    Task.Delay(400);
                    Console.WriteLine("MultiThread Task 1");
                } 
                );
            stopwatch2.Stop();
            Console.WriteLine("Parallel.Invoke => " + stopwatch2.ElapsedMilliseconds);

            List<string> Urls = new List<string>
            { 
               "http://www.cnn.com" ,
               "http://www.amazon.com"
            };

            Parallel.For(0, 2, (i) =>
            {
                Download(Urls[i]);
            });

            Parallel.ForEach(Urls, (Url) =>
            {
                Download(Url);
            });

            Console.ReadKey();
        }
        
    }
}
