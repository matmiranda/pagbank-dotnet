namespace PagBankTest
{
    public class Tests
    {
        static readonly string token = "123";
        private readonly PagBankClient client = new(BaseUrl.Sandbox, token);


        [Test]
        public async Task Test1()
        {
            var header = new Dictionary<string, string>();
            header.Add("Authorization", $"Bearer {token}");
            header.Add("accept", "application/json");

            var response = await client.GetAsync("public-keys/card");
            Assert.Pass();
        }
    }
}