namespace PagBank
{
    public class PagBankClient : IPagBankClient
    {
        private readonly string _token;
        private readonly BaseUrl _baseUrl;        
        private readonly IRestClient _restClient;

        public PagBankClient(BaseUrl baseUrl, string token, IRestClient? restClient = null)
        {
            _token = token;
            _baseUrl = baseUrl;
            _restClient = restClient ?? new RestClient(RestClientOptions());
        }

        public async Task<RestResponse> ExecuteAsync<T>(PagBankRequest<T> pagBankRequest) where T : class
        {
            var request = new RestRequest(pagBankRequest.Endpoint, (RestSharp.Method)pagBankRequest.Method);
            if (pagBankRequest.Body != null)
                request.AddJsonBody(pagBankRequest.Body, ContentType.Json);
            request.AddOrUpdateHeader("accept", ContentType.Json);
            request.AddOrUpdateHeader("user-agent", GetUserAgent());
            if (pagBankRequest.Headers != null)
                foreach (var header in pagBankRequest.Headers)
                    request.AddOrUpdateHeader(header.Key, header.Value);
            return await _restClient.ExecuteAsync(request);
        }

        private RestClientOptions RestClientOptions()
        {
            var options = new RestClientOptions(_baseUrl.GetDescription());
            options.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(_token, "Bearer");
            return options;
        }

        internal static string GetUserAgent()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var attribute = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
            var version = attribute?.InformationalVersion;
            return $"pagbank-dotnet/{version}";
        }
    }
}
