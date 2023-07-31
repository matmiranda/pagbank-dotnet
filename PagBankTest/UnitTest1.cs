using PagBank;

namespace PagBankTest
{
    public class Tests
    {
        private static readonly string token = "123";
        private static readonly PagBankClient client = new(BaseUrl.Sandbox, token);

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
                    name = "João Silva"
                },
                reference_id = "1234"
            };

            var response = await client.ExecuteAsync(Method.Post, "orders", body, header);
            Assert.Pass();
        }
    }
}