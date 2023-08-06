namespace PagBank
{
    public interface IPagBankConfig
    {
        BaseUrl BaseUrl { get; }
        string Token { get; }
        IRestClient? RestClient { get; }
    }
}
