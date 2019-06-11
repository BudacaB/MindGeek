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
        private static async Task<string> Fetch(string urlToUse)
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

        private static List<Movie> ParseMovies(string toParse)
        {
            List<Movie> movies = JsonConvert.DeserializeObject<List<Movie>>(toParse);

            return movies;
        }

        public static List<string> ExtractImagesfromUrl(string urlToUse)
        {
            string result = Fetch(urlToUse).Result;

            List<Movie> allMovies = ParseMovies(result);

            List<string> cardImagesURLs = new List<string>();

            foreach (Movie movie in allMovies)
            {
                foreach (CardImage cardImage in movie.cardImages)
                {
                    cardImagesURLs.Add(cardImage.url);
                }
            }
            return cardImagesURLs;
        }

    }

    public class CardImage
    {
        public string url { get; set; }
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Movie
    {
        public List<CardImage> cardImages { get; set; }
    }
}
