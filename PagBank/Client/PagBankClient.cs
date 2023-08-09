namespace PagBank
{
    public class PagBankClient : IPagBankClient
    {
        private IRestClient RestClient { get; set; }
        private RestRequest RestRequest { get; set; }

        public PagBankClient(IRestClient? restClient = null, RestRequest? restRequest = null)
        {
            RestClient = restClient ?? new RestClient();
            RestRequest = restRequest ?? new RestRequest();
        }

        public async ValueTask<RestResponse> ExecuteAsync()
        {
            RestRequest.AddOrUpdateHeader("user-agent", PagBankUtil.GetUserAgent());
            return await RestClient.ExecuteAsync(RestRequest);
        }

        public PagBankClient WithBaseUrl(BaseUrl baseUrl)
        {
            RestClient = new RestClient(baseUrl.GetDescription());
            return this;
        }

        public PagBankClient WithToken(string token)
        {
            RestRequest.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(token, "Bearer");
            return this;
        }

        public PagBankClient WithClientId(string clientId)
        {
            RestRequest.AddOrUpdateHeader("x-client-id", clientId);
            return this;
        }

        public PagBankClient WithClientSecret(string clientSecret)
        {
            RestRequest.AddOrUpdateHeader("x-client-secret", clientSecret);
            return this;
        }

        public PagBankClient WithJsonBody(PagBankBody body)
        {
            RestRequest.AddJsonBody(body);
            return this;
        }

        public PagBankClient WithMethod(PagBankMethod method)
        {
            RestRequest.Method = (Method)method;
            return this;
        }

        public PagBankClient AddOrUpdateHeader(string key, string value)
        {
            RestRequest.AddOrUpdateHeader(key, value);
            return this;
        }
        public PagBankClient WithResource(string resource)
        {
            RestRequest.Resource = resource;
            return this;
        }
    }
}
