namespace PagBank
{
    public class PagBankSetting : IPagBankSetting
    {
        public BaseUrl? BaseUrl { get; set; }
        public string? Token { get; set; }
        public string? ClientId { get; set; }
        public string? ClientSecret { get; set; }
        public IRestClient? RestClient { get; set; }        
    }
}
