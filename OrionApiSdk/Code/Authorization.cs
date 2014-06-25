using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OrionApiSdk.Classes.Authorization;

namespace OrionApiSdk.Code
{
    public class Authorization : ApiBase 
    {
        internal Authorization(HttpClient httpClient) : base(httpClient) { }


        public User User()
        {
            var response = base.httpClient.GetAsync("Authorization/User").Result;

            response.EnsureSuccessStatusCode();

            // return the json, and write it to a dictionary for easier parse.
            var j = response.Content.ReadAsStringAsync().Result;
            var d = JsonConvert.DeserializeObject<User>(j);

            return d;
        }

    }
}
