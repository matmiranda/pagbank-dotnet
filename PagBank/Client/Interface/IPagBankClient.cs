namespace PagBank
{
    public interface IPagBankClient
    {
        ValueTask<RestResponse> ExecuteAsync();
    }
}
