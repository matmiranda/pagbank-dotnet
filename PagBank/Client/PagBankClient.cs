namespace PagBank.Client
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

        public async Task<RestResponse> ExecuteAsync<T>(Method method, string endpoint, T body) where T : class
        {
            var options = new RestClientOptions(_baseUrl.GetDescription());
            options.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(_token, "Bearer");
            using var client = new RestClient(options);
            var request = new RestRequest(endpoint, method);
            request.AddJsonBody(body, ContentType.Json);
            request.AddHeader("accept", ContentType.Json);
            return await client.ExecuteAsync(request);
        }

        public async Task<RestResponse> ExecuteAsync(Method method, string endpoint)
        {
            var options = new RestClientOptions(_baseUrl.GetDescription());
            options.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(_token, "Bearer");
            using var client = new RestClient(options);
            var request = new RestRequest(endpoint, method);
            request.AddHeader("accept", ContentType.Json);
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
