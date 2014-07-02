using System;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

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

            var j = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                // try to parse the validation errors.
                throw new Exception(j);
            }

            response.EnsureSuccessStatusCode();  // throws an error if any other error codes were returned.
            return j;
        }

        public string PostJson(string endpoint, object body) {
            var content = new StringContent( JsonConvert.SerializeObject( body ) );

            var response = httpClient.PostAsync( endpoint, content ).Result;
            
            var j = response.Content.ReadAsStringAsync().Result;

            if( !response.IsSuccessStatusCode ) {
                // try to parse the validation errors.
                throw new Exception( j );
            }
            
            response.EnsureSuccessStatusCode();  // throws an error if any other error codes were returned.
            return j;
        }

        public string PutJson(string endpoint, object body)
        {
            var content = new StringContent(JsonConvert.SerializeObject(body));

            var response = httpClient.PutAsync(endpoint, content).Result;

            var j = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                // try to parse the validation errors.
                throw new Exception(j);
            }

            response.EnsureSuccessStatusCode();  // throws an error if any other error codes were returned.
            return j;
        }

    }
}
