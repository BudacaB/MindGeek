using MindGeek.ImageManipulation;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

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
            List<string> cardImages = ImageManipulation.ExtractImagesfromUrl("https://mgtechtest.blob.core.windows.net/files/showcase.json");

            foreach (string cardImage in cardImages)
            {
                Console.WriteLine(cardImage);
            }
        }
    }

}
