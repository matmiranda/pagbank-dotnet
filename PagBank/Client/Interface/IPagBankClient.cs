namespace PagBank.Client.Interface
{
    public interface IPagBankClient
    {
        Task<PagBankResponse> GetAsync(string endpoint, IDictionary<string, string>? header = null);
        Task<PagBankResponse> PostAsync(string endpoint, string? content = null, IDictionary<string, string>? header = null);
        Task<PagBankResponse> PutAsync(string endpoint, string? content = null, IDictionary<string, string>? header = null);
        Task<PagBankResponse> DeleteAsync(string endpoint, IDictionary<string, string>? header = null);
    }
}
