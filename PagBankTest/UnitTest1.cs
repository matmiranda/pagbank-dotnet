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
            var body = new PagBankRequest
            {
                Amount = new Amount { Currency = "BRL", Value = 150099 },
                Interval = new Interval { Unit = "MONTH", Length = 1 },
                Trial = new Trial { Enabled = true, HoldSetupFee = false },
                PaymentMethod = new List<string> { "CREDIT_CARD" },
                Name = "meu plano 1",
                Description = "descrição do meu plano",
                SetupFee = 10
            };

            var client = new PagBankClient();
            client.WithBaseUrl(BaseUrl.SandboxSignature);
            client.WithMethod(PagBankMethod.Post);
            client.WithToken("123");
            //client.AddOrUpdateHeader("","");
            client.WithJsonBody(body);
            client.WithResource("plans");
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