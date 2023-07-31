namespace PagBank
{
    public class PagBankClient : IPagBankClient
    {
        private readonly BaseUrl _baseUrl;
        private readonly string _token;

        public PagBankClient(BaseUrl baseUrl, string token)
        {
            _baseUrl = baseUrl;
            _token = token;
        }

        public async Task<RestResponse> ExecuteAsync<T>(PagBankRequest<T> pagBankRequest) where T : class
        {
            var options = new RestClientOptions(_baseUrl.GetDescription());
            options.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(_token, "Bearer");
            using var client = new RestClient(options);
            var request = new RestRequest(pagBankRequest.Endpoint, (RestSharp.Method)pagBankRequest.Method);
            if (pagBankRequest.Body != null)
                request.AddJsonBody(pagBankRequest.Body, ContentType.Json);
            request.AddHeader("accept", ContentType.Json);
            if (pagBankRequest.Headers != null)
                foreach (var header in pagBankRequest.Headers)
                    request.AddOrUpdateHeader(header.Key, header.Value);
            return await client.ExecuteAsync(request);
        }

        internal static string? GetVersion()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var attribute = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
            return attribute?.InformationalVersion;
        }
    }
}
