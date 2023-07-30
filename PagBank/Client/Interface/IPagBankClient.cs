namespace PagBank.Client.Interface
{
    public interface IPagBankClient
    {
        Task<RestResponse> ExecuteAsync<T>(Method method, string endpoint, T body) where T : class;
        Task<RestResponse> ExecuteAsync(Method method, string endpoint);
    }
}
