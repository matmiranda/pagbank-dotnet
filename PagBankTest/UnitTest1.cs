using PagBank;

namespace PagBankTest
{
    public class Tests
    {
        private static string token = "123";
        private static PagBankClient client = new(BaseUrl.Sandbox, token);

        [Test]
        public async Task Test1()
        {
            var header = new Dictionary<string, string>();
            header.Add("accept", "application/json");

            var body = new
            {
                customer = new
                {
                    tax_id = "62046100077",
                    email = "teste@teste.com.br",
                    name = "Jo�o Silva"
                },
                reference_id = "1234"
            };

            var request = new PagBankRequest<object>
            {
                Body = body,
                Method = Method.Post,
                Endpoint = "orders"
            };

            var response = await client.ExecuteAsync(request);

            Assert.Pass();
        }
    }
}