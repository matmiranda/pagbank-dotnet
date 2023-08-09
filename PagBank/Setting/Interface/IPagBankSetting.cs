namespace PagBank
{
    public interface IPagBankSetting
    {
        BaseUrl? BaseUrl { get; set; }
        string? Token { get; set; }
        string? ClientId { get; set; }
        string? ClientSecret { get; set; }
        IRestClient? RestClient { get; set; }
    }
}
