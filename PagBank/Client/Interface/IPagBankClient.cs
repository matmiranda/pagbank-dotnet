namespace PagBank
{
    public interface IPagBankClient
    {
        Task<RestResponse> ExecuteAsync<T>(PagBankRequest<T> pagBankRequest) where T : class;
    }
}
