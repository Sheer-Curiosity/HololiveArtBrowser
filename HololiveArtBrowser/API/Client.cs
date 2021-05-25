using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HololiveArtBrowser.API
{
    public class ArtResponse
    {
        public bool success { get; set; }
        public IList<Post> results { get; set; }
        public string query { get; set; }
        public int total { get; set; }
        public float took { get; set; }
        public float php_took { get; set; }
        public int count { get; set; }
        public int limit { get; set; }
        public int page { get; set; }
        public int offset { get; set; }
        public int? next_page { get; set; }
        public string search { get; set; }
    }
    public class Post
    {
        public string md5 { get; set; }
        public string hash { get; set; }
        public int created { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public float aspect { get; set; }
        public string rating { get; set; }
        public string tag { get; set; }
        public string tags { get; set; }
        public string url { get; set; }
        public string site { get; set; }
        public string kind { get; set; }
        public string preview { get; set; }
        public string source { get; set; }
        public string extension { get; set; }
        public string id { get; set; }
        public string size { get; set; }
        public string page { get; set; }
        public string sourceURL { get; set; }
        public string pixiv { get; set; }
        public string userID { get; set; }
        public string userName { get; set; }
        public string userUrl { get; set; }
        public string hasChildren { get; set; }
        public string parentHash { get; set; }
        public string parentID { get; set; }
    }
    class Client
    {
        private static string apiUrl = "https://cure.ninja/booru/api/json/1";
        private static string baseParam = "?o=r";

        static HttpClient client = new HttpClient();

        public static async Task<ArtResponse> GetArt(string type = null, string tags = null)
        {
            string extraParams = null;
            Console.WriteLine(tags);
            tags = "&q=hololive" + tags;
            if (type != null)
            {
                if (type == "Safe")
                {
                    extraParams = extraParams + "&f=s";
                }
                else if (type == "Questionable")
                {
                    extraParams = extraParams + "&f=q";
                }
                else if (type == "Explicit")
                {
                    extraParams = extraParams + "&f=e";
                }
                else if (type == "Any")
                {
                    extraParams = extraParams + "&f=a";
                }
            }
            string initReq = apiUrl + baseParam + extraParams + tags;
            Console.WriteLine(initReq);
            var req1 = client.GetAsync(initReq);
            var res1 = await req1;
            string fullRes1 = await res1.Content.ReadAsStringAsync();
            ArtResponse parsedRes1 = JsonConvert.DeserializeObject<ArtResponse>(fullRes1);

            return parsedRes1;
        }
    }
}
