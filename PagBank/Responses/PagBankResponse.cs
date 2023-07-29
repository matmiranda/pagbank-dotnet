using System.Net;

namespace PagBank.Responses
{
    public class PagBankResponse
    {
        public HttpStatusCode HttpStatusCode { get; set; }
        public string? Content { get; set; }         
    }
}
