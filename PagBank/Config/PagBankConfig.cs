namespace PagBank
{
    public class PagBankConfig : IPagBankConfig
    {
        public required BaseUrl BaseUrl { get; set; }
        public required string Token { get; set; }
        public IRestClient? RestClient { get; set; }
    }
}
