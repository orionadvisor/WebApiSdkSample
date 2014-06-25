using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using OrionApiSdk.Classes.Enums;
using OrionApiSdk.Code;

namespace OrionApiSdk
{
    public static class OrionApi
    {

        #region Members
        private static HttpClient _httpClient;
        private static string _apiUrl ;
        private static string _orionConnectUrl;



        private static Code.Portfolio _portfolio;
        public static Code.Portfolio Portfolio {
            get { return _portfolio ?? ( _portfolio = new Code.Portfolio( _httpClient ) ); }
        }

        private static Code.Authorization _authorization;
        public static Code.Authorization Authorization
        {
            get { return _authorization ?? (_authorization = new Code.Authorization(_httpClient)); }
        }

        private static Code.OrionConnectLinks _links;
        public static Code.OrionConnectLinks OrionConnectLinks {
            get { return _links ?? ( _links = new OrionConnectLinks( _orionConnectUrl ) ); }
        }

        private static void reset( ) {
            _portfolio = null;
            _authorization = null;
        }

        #endregion

        /// <summary>
        /// Specifies the orion environment to connect to.
        /// </summary>
        /// <param name="environment">Specify the Orion Test or Production Environment.</param>
        public static void SetConnection( OrionEnvironment environment ) {
            if( environment == OrionEnvironment.Test ) {
                _apiUrl = "https://testapi.orionadvisor.com/api/v1/";
                _orionConnectUrl = "https://testapp.orionadvisor.com/integration.html";
            } else {
                _apiUrl = "https://api.orionadvisor.com/api/v1/";
                _orionConnectUrl = "https://app.orionadvisor.com/integration.html";
            }
        }
        #region Authentication
        public static string AuthToken { get; set; }

        /// <summary>
        /// Authenticates the user based on userid and password.  If successful, it stores the Api Token in the HttpClient for future api calls.
        /// </summary>
        /// <param name="uid">Orion UserId</param>
        /// <param name="pwd">Orion Password</param>
        public static void Authenticate( string uid, string pwd ) {

            if( String.IsNullOrEmpty( _apiUrl ) ) {
                throw new Exception("The connection has not been set.  Call SetConnection() to establish the urls for the desired Orion Environment.");
            }

            var client = new HttpClient
            {
                BaseAddress = new Uri(_apiUrl)
            };

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue( "Basic", Convert.ToBase64String( System.Text.ASCIIEncoding.ASCII.GetBytes( string.Format( "{0}:{1}", uid, pwd ) ) ) );


            var response = client.GetAsync("security/token").Result;
            response.EnsureSuccessStatusCode();

            // return the json, and write it to a dictionary for easier parse.
            var j = response.Content.ReadAsStringAsync().Result;
            var d = JsonConvert.DeserializeObject<Dictionary<string, string>>(j);

            // save the token for future calls to web api.  The httpclient gets the "Session" auth header with the auth token form this point forward.
            AuthToken = d["access_token"];
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(_apiUrl)
            };
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Session", AuthToken);
            reset(  );
        }

        /// <summary>
        /// Returns true if the token is valid, false if it is not.
        /// </summary>
        /// <param name="authToken">Orion WebApi token</param>
        /// <returns></returns>
        public static bool SetToken(string authToken)
        {
            if (String.IsNullOrEmpty(_apiUrl))
            {
                throw new Exception("The connection has not been set.  Call SetConnection() to establish the urls for the desired Orion Environment.");
            }
            // this method will validate the token, if it is valid, it will get set as the defult header.
            var client = new HttpClient
            {
                BaseAddress = new Uri(_apiUrl)
            };

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Session", authToken);


            var response = client.GetAsync("authorization/user").Result;

            if( response.IsSuccessStatusCode ) {
                // save the token for future calls to web api.  The httpclient gets the "Session" auth header with the auth token form this point forward.
                AuthToken = authToken;
                _httpClient = new HttpClient {
                    BaseAddress = new Uri( _apiUrl )
                };
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue( "Session", AuthToken );
                reset();
                return true;
            } else {
                return false;
            }


        }


        #endregion

    }
}
