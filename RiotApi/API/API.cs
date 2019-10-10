using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;

namespace RiotApi.API
{
    public class API
    {
        private string Key { get; set; }
        private string Region { get; set; }

        public API(string region)
        {
            Region = region;
            Key = GetAPIKey("API/APIKey.txt");
        }

        protected HttpResponseMessage GetHttpResponse(string URL)
        {
            using (HttpClient client = new HttpClient())
            {
                var result = client.GetAsync(URL);
                result.Wait();

                return result.Result;
            }
        }

        protected string GetCombinedURI(string path)
        {
            return "https://" + Region + ".api.riotgames.com/lol/" + path + "?api_key=" + Key;
        }

        public string GetAPIKey(string path)
        {
            StreamReader sr = new StreamReader(path);
            return sr.ReadToEnd();
        }
    }
}
