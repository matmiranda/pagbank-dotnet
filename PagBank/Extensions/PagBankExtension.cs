using PagBank.Responses;
using System.ComponentModel;

namespace PagBank.Extensions
{
    public static class PagBankExtension
    {
        public static async Task<PagBankResponse> GetPagBankResponseAsync(this HttpResponseMessage response)
        {
            return new PagBankResponse
            {
                HttpStatusCode = response.StatusCode,
                Content = await response.Content.ReadAsStringAsync()
            };
        }
    }
}
