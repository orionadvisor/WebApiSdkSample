using System.Net.Http;

namespace OrionApiSdk.Code
{
     public class ApiBase {
        internal HttpClient httpClient;
        internal ApiBase( HttpClient httpClient ) {
            this.httpClient = httpClient;
        }

        public string GetJson(string endpoint)
        {
            var response = httpClient.GetAsync(endpoint).Result;

            response.EnsureSuccessStatusCode();

            // return the json, and write it to a dictionary for easier parse.
            var j = response.Content.ReadAsStringAsync().Result;
            return j;
        }
    }
}
