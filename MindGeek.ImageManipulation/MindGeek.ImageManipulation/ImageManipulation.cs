using System;
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

    }
}
