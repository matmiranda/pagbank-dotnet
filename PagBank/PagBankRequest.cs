namespace PagBank
{
    public class PagBankRequest<T>
    {
        public T? Body { get; set; }
        public IDictionary<string, string>? Headers { get; set; }
        public Method Method { get; set; }
        public string? Endpoint { get; set; }
    }
}
