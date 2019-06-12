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
        public static void Main()
        {
            List<string> cardImagesURLs = ImageManipulation.ExtractImagesfromUrl("https://mgtechtest.blob.core.windows.net/files/showcase.json");

            foreach (string cardImageURL in cardImagesURLs)
            {
                Console.WriteLine(cardImageURL);
            }
        }
    }

}
