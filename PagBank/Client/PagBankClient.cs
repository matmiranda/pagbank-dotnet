namespace PagBank
{
    public class PagBankClient : IPagBankClient
    {
        private readonly PagBankConfig _pagBankConfig;

        public PagBankClient(PagBankConfig pagBankConfig)
        {
            _pagBankConfig = pagBankConfig;
        }

        public async Task<RestResponse> ExecuteAsync<T>(PagBankRequest<T> pagBankRequest) where T : class
        {
            _pagBankConfig.RestClient ??= new RestClient(PagBankUtil.RestClientOptions(_pagBankConfig));
            var request = new RestRequest(pagBankRequest.Endpoint, (RestSharp.Method)pagBankRequest.Method);
            if (pagBankRequest.Body != null)
                request.AddJsonBody(pagBankRequest.Body, ContentType.Json);
            request.AddOrUpdateHeader("accept", ContentType.Json);
            request.AddOrUpdateHeader("user-agent", PagBankUtil.GetUserAgent());
            if (pagBankRequest.Headers != null)
                foreach (var header in pagBankRequest.Headers)
                    request.AddOrUpdateHeader(header.Key, header.Value);
            return await _pagBankConfig.RestClient.ExecuteAsync(request);
        }
    }
}
