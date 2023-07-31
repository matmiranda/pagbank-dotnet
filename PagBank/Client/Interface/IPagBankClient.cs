namespace PagBank.Client.Interface
{
    public interface IPagBankClient
    {
        Task<RestResponse> ExecuteAsync<T>(
            Method method, 
            string endpoint, 
            T body, 
            IDictionary<string, string>? headers = null) where T : class;
        Task<RestResponse> ExecuteAsync(
            Method method, 
            string endpoint, 
            IDictionary<string, string>? headers = null);
    }
}
