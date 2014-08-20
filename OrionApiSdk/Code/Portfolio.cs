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

        /// <summary>
        /// Returns an initialized new ClientVerbose object
        /// </summary>
        /// <returns></returns>
        public ClientVerbose ClientVerboseNew()
        {
            var endpoint = string.Format("Portfolio/Clients/Verbose/New");

            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<ClientVerbose>(j);

            return d;
        }

        /// <summary>
        /// Returns a verbose client object for the specified client id.
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public ClientVerbose ClientVerbose( int clientId )
        {
            var endpoint = string.Format("Portfolio/Clients/Verbose/{0}", clientId);

            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<ClientVerbose>(j);

            return d;
        }

        /// <summary>
        /// Adds or Updates the client record, and returns the updated ClientVerbose object.  If the client.Id == 0, the record will be added, if it has a client id, the client record will be updated.
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public ClientVerbose ClientSave(ClientVerbose clientVerbose) {
            var endpoint = string.Empty;
            var j = string.Empty;

            if( clientVerbose.id == 0 ) {
                // new 
                endpoint = string.Format("Portfolio/Clients/Verbose");
                j = base.PostJson(endpoint, clientVerbose);
            } else {
                // update
                endpoint = string.Format("Portfolio/Clients/Verbose/{0}", clientVerbose.id);
                j = base.PutJson(endpoint, clientVerbose);
            }



           var d = JsonConvert.DeserializeObject<ClientVerbose>( j );


            return d;
        }

        #endregion

        #region Registrations
        public List<RegistrationSimple> RegistrationsSimple(int top = 50000, int skip = 0,  bool? isActive = null)
        {
            var endpoint = string.Format("Portfolio/Registrations/Simple?isActive={0}&$top={1}&$skip={2}", isActive, top, skip);
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<RegistrationSimple>>(j);

            return d;
        }

        public RegistrationVerbose RegistrationVerbose( int registrationId )
        {
            var endpoint = string.Format("Portfolio/Registrations/Verbose/{0}", registrationId );
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<RegistrationVerbose > (j);

            return d;
        }

        public RegistrationVerbose RegistrationVerboseNew() {
            var endpoint = string.Format( "Portfolio/Registrations/Verbose/New" );
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<RegistrationVerbose>(j);

            return d;
        }

        public RegistrationVerbose RegistrationSave(RegistrationVerbose registrationVerbose )
        {
            var endpoint = string.Empty;
            var j = string.Empty;

            if (registrationVerbose.id == 0)
            {
                // new 
                endpoint = string.Format("Portfolio/Registrations/Verbose");
                j = base.PostJson(endpoint, registrationVerbose);
            }
            else
            {
                // update
                endpoint = string.Format("Portfolio/Registrations/Verbose/{0}", registrationVerbose.id);
                j = base.PutJson(endpoint, registrationVerbose);
            }



            var d = JsonConvert.DeserializeObject<RegistrationVerbose>(j);


            return d;
        }

        public List<RegistrationSimple> RegistrationsSearch(string searchText, int top = 50000, int skip = 0)
        {
            var endpoint = string.Format("Portfolio/Registrations/Simple/Search?$top={0}&$skip={1}&search={2}", top, skip, searchText);
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<RegistrationSimple>>(j);

            return d;
        }

        public List<Registration> Registrations(int top = 50000, int skip = 0, bool? isActive = null)
        {
            var endpoint = string.Format("Portfolio/Registrations?isActive={0}&$top={1}&$skip={2}", isActive, top, skip);
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<Registration>>(j);

            return d;
        }

        public List<Registration> RegistrationsForClient(int clientId) {
            var endpoint = string.Format( "Portfolio/Clients/{0}/Registrations", clientId );
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<Registration>>(j);

            return d;
        }

        #endregion

        #region Representatives/Advisors
        public List<Simple> RepresentativesSimple(int top = 50000, int skip = 0)
        {
            var endpoint = string.Format("Portfolio/Representatives/Simple?$top={0}&$skip={1}", top, skip);
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<Simple>>(j);

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

        public AccountVerbose AccountVerbose(int accountId)
        {
            var endpoint = string.Format("Portfolio/Accounts/Verbose/{0}", accountId);
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<AccountVerbose>(j);

            return d;
        }

        public AccountVerbose AccountVerboseNew()
        {
            var endpoint = string.Format("Portfolio/Accounts/Verbose/New");
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<AccountVerbose>(j);

            return d;
        }

        public AccountVerbose AccountSave(AccountVerbose accountVerbose)
        {
            var endpoint = string.Empty;
            var j = string.Empty;

            if (accountVerbose.id == 0)
            {
                // new 
                endpoint = string.Format("Portfolio/Accounts/Verbose");
                j = base.PostJson(endpoint, accountVerbose);
            }
            else
            {
                // update
                endpoint = string.Format("Portfolio/Accounts/Verbose/{0}", accountVerbose.id);
                j = base.PutJson(endpoint, accountVerbose);
            }



            var d = JsonConvert.DeserializeObject<AccountVerbose>(j);


            return d;
        }
        #endregion

        #endregion


        #region Lookup Tables
        public List<AccountTypeSimple> AccountTypes()
        {
            var endpoint = string.Format("Portfolio/Registrations/Types");
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<AccountTypeSimple>>(j);

            return d;
        }

        public List<Simple> BrokerDealersSimple()
        {
            var endpoint = string.Format("Portfolio/BrokerDealers/Simple");
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<Simple>>(j);

            return d;
        }

        public List<Simple> CustodiansSimple()
        {
            var endpoint = string.Format("Portfolio/Custodians/Simple");
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<Simple>>(j);

            return d;
        }

        public List<Simple> FundFamiliesSimple()
        {
            var endpoint = string.Format("Portfolio/FundFamilies/Simple");
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<Simple>>(j);

            return d;
        }

        public List<RepresentativeSimple> RepresentativesSimple()
        {
            var endpoint = string.Format("Portfolio/Representatives/Simple");
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<RepresentativeSimple>>(j);

            return d;
        }
        #endregion

    }
}
