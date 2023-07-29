namespace PagBank.Client
{
    public class PagBankClient : IPagBankClient, IDisposable
    {
        private static readonly HttpClient _httpClient = new();

        public PagBankClient(BaseUrl baseUrl, string token)
        {
            _httpClient.BaseAddress = new Uri(baseUrl.GetDescription());
            _httpClient.DefaultRequestHeaders.Authorization = new("Bearer", token);
            _httpClient.DefaultRequestHeaders.UserAgent.Add(new("pagbank-dotnet", GetVersion()));
        }

        public async Task<PagBankResponse> GetAsync(string endpoint, IDictionary<string, string>? header = null)
        {
            ClearHeaderIfExists(header);
            var response = await _httpClient.GetAsync(endpoint);
            return await response.GetPagBankResponseAsync();
        }

        public async Task<PagBankResponse> PostAsync(string endpoint, string? content = null, IDictionary<string, string>? header = null)
        {
            ClearHeaderIfExists(header);
            var httpContent = string.IsNullOrEmpty(content) ? null : new StringContent(content);
            var response = await _httpClient.PostAsync(endpoint, httpContent);
            return await response.GetPagBankResponseAsync();
        }

        public async Task<PagBankResponse> PutAsync(string endpoint, string? content = null, IDictionary<string, string>? header = null)
        {
            ClearHeaderIfExists(header);
            var httpContent = string.IsNullOrEmpty(content) ? null : new StringContent(content);
            var response = await _httpClient.PutAsync(endpoint, httpContent);
            return await response.GetPagBankResponseAsync();
        }

        public async Task<PagBankResponse> DeleteAsync(string endpoint, IDictionary<string, string>? header = null)
        {
            ClearHeaderIfExists(header);
            var response = await _httpClient.DeleteAsync(endpoint);
            return await response.GetPagBankResponseAsync();
        }

        public void Dispose()
        {
            _httpClient?.Dispose();
            GC.SuppressFinalize(this);
        }

        internal static void ClearHeaderIfExists(IDictionary<string, string>? header)
        {
            if (header != null)
            {
                var authHeader = _httpClient.DefaultRequestHeaders.Authorization;

                _httpClient.DefaultRequestHeaders.Clear();

                foreach (var hdr in header)
                    _httpClient.DefaultRequestHeaders.Add(hdr.Key, hdr.Value);

                _httpClient.DefaultRequestHeaders.Authorization = authHeader;
                _httpClient.DefaultRequestHeaders.UserAgent.Add(new("pagbank-dotnet", GetVersion()));
            }
        }

        internal static string? GetVersion()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var attribute = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
            return attribute?.InformationalVersion;
        }
    }
}
