using MindGeek.ImageManipulation;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleOutput
{
    class Program
    {
        public static void Show(string toShow)
        {
            Console.WriteLine(toShow);
        }

        public static void Main()
        {
            var result = ImageManipulation.Fetch("https://mgtechtest.blob.core.windows.net/files/showcase.json");
            Show(result.Result);
        }
    }
}
