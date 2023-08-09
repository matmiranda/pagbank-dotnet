using Moq;
using PagBank;
using RestSharp;
using System.Net;

namespace PagBankTest
{
    public class Tests
    {
        [Test]
        public async Task TestExample()
        {
            var body = new PagBankBody
            {
                Customer = new Customer
                {
                    TaxId = "62046100077",
                    Email = "teste@teste.com.br",
                    Name = "Test"
                },
                refe
            };
            var client = new PagBankClient();
            client.WithBaseUrl(BaseUrl.Sandbox);
            client.WithMethod(PagBankMethod.Post);
            client.WithToken("your-token");
            client.WithResource("orders");
            var response = await client.ExecuteAsync();
        }

        [Test]
        public async Task MockExecuteAsync()
        {
            var restClientMock = new Mock<IRestClient>();
            var restRequestMock = new Mock<RestRequest>();
            var restResponseMock = new RestResponse();
            restResponseMock.StatusCode = HttpStatusCode.InternalServerError;
            restResponseMock.Content = "Something unexpected happened. Please, contact the PagBank Team";
            restClientMock
                .Setup(x => x.ExecuteAsync(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(restResponseMock);
            var pagBankClient = new PagBankClient(restClientMock.Object, restRequestMock.Object);
            pagBankClient.WithToken("123");
            var response = await pagBankClient.ExecuteAsync();
            Assert.That(response, Is.Not.Null);
        }
    }
}