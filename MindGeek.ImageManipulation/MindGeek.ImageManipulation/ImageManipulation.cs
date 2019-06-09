using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace MindGeek.ImageManipulation
{
    public class ImageManipulation
    {
        public static async Task<string> Fetch(string urlToUse)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string responseBody = await client.GetStringAsync(urlToUse);
                    return responseBody;
                }
                catch (HttpRequestException e)
                {
                    return e.Message;
                }
            }
        }

        public static void ParseImages(string toParse)
        {
            List<Movie> movie = JsonConvert.DeserializeObject<List<Movie>>(toParse);

            Console.WriteLine(movie[0].cardImages[0].url); 

            //foreach (Images image in movie[0].cardImages)
            //{
            //    Console.WriteLine(image.url);
            //}
        }

    }

    public class Images
    {
        public string url { get; set; }
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Movie
    {
        public List<Images> cardImages { get; set; }
    }
}
