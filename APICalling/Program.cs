using Newtonsoft.Json.Linq;
using RestSharp;

namespace APICalling
{
    public class Program
    {
        public static async Task Main(string[] args)
        { 
            var data = await (new Program()).APICall();
            var info = JArray.Parse(data);
            var temp = (JObject)info[0];
            foreach (var i in temp)
            {
                Console.WriteLine(i.Key);
                Console.WriteLine(i.Value??"NULL");
            }
            
        }
        public async Task<string> APICall()
        {
            var options = new RestClientOptions("https://ct.azurewebsites.net")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/api/data", Method.Get);

            RestResponse response = await client.ExecuteAsync(request);
            //Console.WriteLine(response.Content);
            return response.Content;
        }
    }
    
}
