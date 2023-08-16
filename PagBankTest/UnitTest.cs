using Moq;
using PagBank;
using RestSharp;
using System.Net;
using System.Reflection;

namespace PagBankTest
{
    public class Tests
    {
        [Test]
        public async Task SandBoxInvalidToken()
        {
            var client = new PagBankClient();
            client.WithBaseUrl(BaseUrl.Sandbox);
            client.WithMethod(PagBankMethod.Get);
            client.WithToken("your-token");
            client.WithResource("{seu-recurso}");
            client.WithJsonBody(new PagBankBody());
            client.AddOrUpdateHeader("custom-header", "123");
            var response = await client.ExecuteAsync();
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Forbidden));
        }
        [Test]
        public async Task MockExemploBasico()
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
        [Test]
        public async Task MockCriarConta()
        {
            //arquivo mock response
            //var fileName = "MockResponse\\CriarConta_Buyer.json";
            //var jsonFilePath = $"{AppDomain.CurrentDomain.BaseDirectory}{fileName}";
            //var jsonContent = File.ReadAllText(jsonFilePath);

            var restClientMock = new Mock<IRestClient>();
            var restRequestMock = new Mock<RestRequest>();
            var restResponseMock = new RestResponse();
            var jsonReponse = 
            restResponseMock.StatusCode = HttpStatusCode.InternalServerError;
            restResponseMock.Content = "Something unexpected happened. Please, contact the PagBank Team";
            restClientMock
                .Setup(x => x.ExecuteAsync(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(restResponseMock);
            var pagBankClient = new PagBankClient(restClientMock.Object, restRequestMock.Object);
            pagBankClient.WithBaseUrl(BaseUrl.Sandbox);
            pagBankClient.WithMethod(PagBankMethod.Post);
            pagBankClient.WithToken("your-token");
            pagBankClient.WithClientId("your-client-id");
            pagBankClient.WithClientSecret("your-client-secret");
            var response = await pagBankClient.ExecuteAsync();
            Assert.That(response, Is.Not.Null);
        }
    }
}