using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _10_Async_Await
{
    internal class Program
    {
        static async Task<string> DownloadContentAsync(string url)
        {
            string content;
            using(WebClient client = new WebClient())
            {
                content = client.DownloadString(url);
                await Task.Delay(400);
                Console.WriteLine($"this {url} has : {content.Length} chars");

                return content;
            }

        }
        static List<string> Urls = new List<string>
        {
            "http://www.cnn.com",
            "http://www.amazon.com",
            "http://www.programingadvices.com"
        };
        static async Task  Main(string[] args)
        {
            // Asyncronouse Programing
            // faster than Syncronouse Programing => (it is use idel time to do some tasks)

            // async => to define a Asyncronous Function
            // await => to wait the data comming


            // string WebContent = await DownloadContentAsync(Urls[0]);
            Task <string> WebContent = DownloadContentAsync(Urls[0]);

            string WebContentStr = await WebContent;

            Console.WriteLine(WebContentStr);
            Console.ReadKey();

        }
    }
}
