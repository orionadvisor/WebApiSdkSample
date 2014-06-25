using OrionApiSdk.Classes.Enums;

namespace OrionApiSdk.Code
{
    public class OrionConnectLinks {
        private readonly string _orionConnectUrl;

        internal OrionConnectLinks( string orionConnectUrl ) {
            _orionConnectUrl = orionConnectUrl;
        }

        public string HouseholdOverview( Entity entity, int entityId ) {
            const string page = "/portfolio/household/overview"; // this is the page to take the user to (household overview)
            var pageParameters = System.Net.WebUtility.UrlEncode(string.Format("?entity={0}&entityId={1}", (int)entity, entityId)); // entity=5 (5=Client, 7=Account).

            // add the auth token to the string, and launch the url, passing the auth token.
            string url = string.Format("{0}?t={1}&p={2}{3}", _orionConnectUrl, OrionApi.AuthToken, page, pageParameters);

            return url;
        }
        public string AppsMenu()
        {

            // add the auth token to the string, and launch the url, passing the auth token.
            string url = string.Format("{0}?t={1}", _orionConnectUrl, OrionApi.AuthToken);

            return url;
        }
    }
}
