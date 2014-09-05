using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using OrionApiSdk.Classes.LaserApp;

namespace OrionApiSdk.Code
{
    public class LaserApp : ApiBase
    {
        internal LaserApp(HttpClient httpClient) : base(httpClient) { }

        #region Accounts
        public List<Form> AccountForms(int accountId)
        {
            var endpoint = string.Format("Integrations/LaserApp/Accounts/{0}/Forms", accountId);
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<Form>>(j);

            return d;
        }

        public string AccountSubmit(int accountId, List<Form> forms)
        {
            var endpoint = string.Format("Integrations/LaserApp/Accounts/{0}/Submit", accountId);
            var redirectUrl = base.PostJson(endpoint, forms);

            return redirectUrl;
        }

        #endregion
    }
}
