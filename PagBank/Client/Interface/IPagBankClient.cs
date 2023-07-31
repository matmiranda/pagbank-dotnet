namespace PagBank.Client.Interface
{
    public interface IPagBankClient
    {
        Task<RestResponse> ExecuteAsync<T>(PagBankRequest<T> pagBankRequest) where T : class;
    }
}
