using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using OrionApiSdk.Classes.Portfolio;

namespace OrionApiSdk.Code
{
    public class Portfolio : ApiBase
    {
        internal Portfolio(HttpClient httpClient) : base(httpClient) { }

        #region Clients
        public List<Client> Clients(int top = 50000, int skip = 0, bool? hasValue = null, bool? isActive = null)
        {
            var endpoint = string.Format("Portfolio/Clients?hasValue={0}&isActive={1}&$top={2}&$skip={3}", hasValue, isActive, top, skip);
            var j = base.GetJson( endpoint );
            var d = JsonConvert.DeserializeObject<List<Client>>(j);

            return d;
        }

        public List<ClientSimple> ClientsSimple(int top = 50000, int skip = 0, bool? hasValue = null, bool? isActive = null)
        {
            var endpoint = string.Format("Portfolio/Clients/Simple?hasValue={0}&isActive={1}&$top={2}&$skip={3}", hasValue, isActive, top, skip);
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<ClientSimple>>(j);

            return d;
        }

        public List<SimpleValue> ClientsValue(int top = 50000, int skip = 0, bool? hasValue = null, bool? isActive = null)
        {
            var endpoint = string.Format("Portfolio/Clients/Value?hasValue={0}&isActive={1}&$top={2}&$skip={3}", hasValue, isActive, top, skip);
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<SimpleValue>>(j);

            return d;
        }

        public List<ClientSimple> ClientsSearch(string searchText)
        {
            var endpoint = string.Format("Portfolio/Clients/Simple/Search?search={0}", searchText);

            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<ClientSimple>>(j);

            return d;
        }


        public List<SimpleValue> ClientsSearchValue(string searchText)
        {
            var endpoint = string.Format("Portfolio/Clients/Value/Search?search={0}", searchText);

            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<SimpleValue>>(j);

            return d;
        }
        #endregion

        #region Accounts
        public List<Account> Accounts(int top = 50000, int skip = 0, bool? hasValue = null, bool? isActive = null)
        {
            var endpoint = string.Format("Portfolio/Accounts?hasValue={0}&isActive={1}&$top={2}&$skip={3}", hasValue, isActive, top, skip);
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<Account>>(j);

            return d;
        }

        public List<AccountSimple> AccountsSimple(int top = 50000, int skip = 0, bool? hasValue = null, bool? isActive = null)
        {
            var endpoint = string.Format("Portfolio/Accounts/Simple?hasValue={0}&isActive={1}&$top={2}&$skip={3}", hasValue, isActive, top, skip);
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<AccountSimple>>(j);

            return d;
        }

        public List<AccountSimpleValue> AccountsValue(int top = 50000, int skip = 0, bool? hasValue = null, bool? isActive = null)
        {
            var endpoint = string.Format("Portfolio/Accounts/Value?hasValue={0}&isActive={1}&$top={2}&$skip={3}", hasValue, isActive, top, skip);
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<AccountSimpleValue>>(j);

            return d;
        }

        public List<AccountSimple> AccountsSearch(string searchText)
        {
            var endpoint = string.Format("Portfolio/Accounts/Simple/Search?search={0}", searchText);
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<AccountSimple>>(j);

            return d;
        }

        public List<AccountSimpleValue> AccountsValueSearch(string searchText)
        {
            var endpoint = string.Format("Portfolio/Accounts/Value/Search?search={0}", searchText);
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<AccountSimpleValue>>(j);

            return d;
        }

        #region Accounts Verbose

        public List<AccountVerbose> AccountsVerbose( ) {
            var endpoint = string.Format("Portfolio/Accounts/Verbose");
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<AccountVerbose>>(j);

            return d;
        }

        public AccountVerbose AccountVerbose( int accountId)
        {
            var endpoint = string.Format("Portfolio/Accounts/Verbose/{0}", accountId);
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<AccountVerbose>(j);

            return d;
        } 
        #endregion

        #endregion
    }
}
