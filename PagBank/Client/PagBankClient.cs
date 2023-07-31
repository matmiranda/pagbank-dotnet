using RestSharp;
using System.Reflection.PortableExecutable;

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

        public async Task<RestResponse> ExecuteAsync<T>(
            Method method, 
            string endpoint, 
            T body,
            IDictionary<string, string>? headers = null) where T : class
        {
            var options = new RestClientOptions(_baseUrl.GetDescription());
            options.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(_token, "Bearer");
            using var client = new RestClient(options);
            var request = new RestRequest(endpoint, (RestSharp.Method)method);
            request.AddJsonBody(body, ContentType.Json);
            request.AddHeader("accept", ContentType.Json);
            if (headers != null)
                foreach (var header in headers)
                    request.AddOrUpdateHeader(header.Key, header.Value);
            return await client.ExecuteAsync(request);
        }

        public async Task<RestResponse> ExecuteAsync(
            Method method,
            string endpoint, 
            IDictionary<string, string>? headers = null)
        {
            var options = new RestClientOptions(_baseUrl.GetDescription());
            options.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(_token, "Bearer");
            using var client = new RestClient(options);
            var request = new RestRequest(endpoint, (RestSharp.Method)method);
            request.AddHeader("accept", ContentType.Json);
            if (headers != null)
                foreach (var header in headers)
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
