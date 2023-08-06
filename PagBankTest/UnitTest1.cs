using Moq;
using PagBank;
using RestSharp;
using System.Net;

namespace PagBankTest
{
    public class Tests
    {
        [Test]
        public async Task MockCriarPedido()
        {
            // Crie objeto 
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

            // Crie um mock do IRestClientWrapper
            var mockRestClient = new Mock<IRestClient>();

            // Configure o comportamento do mock para o método ExecuteAsync
            var pagBankRequest = new PagBankRequest<object>
            {
                // Defina os valores necessários para o PagBankRequest
                Body = body,
                Method = PagBank.Method.Post,
                Endpoint = "orders"
            };

            // Defina o valor de retorno que você deseja para o método ExecuteAsync
            var restResponse = new RestResponse
            {
                StatusCode = HttpStatusCode.Created,
                Content = "criado com sucesso"
            };

            // Configura o mock para retornar 'restResponse' quando o método 'ExecuteAsync' for chamado
            mockRestClient
                .Setup(x => x.ExecuteAsync(It.IsAny<RestRequest>(), default))
                .ReturnsAsync(restResponse);

            var config = new PagBankConfig 
            {
              BaseUrl = BaseUrl.Sandbox,
              Token = "123",
              RestClient = mockRestClient.Object
            };

            // Create the PagBankClient using the mocked IRestClient
            var pagBankClient = new PagBankClient(config);

            // Chame o método que utiliza o método ExecuteAsync
            var response = await pagBankClient.ExecuteAsync(pagBankRequest);

            // Verifique o resultado
            Assert.That(restResponse, Is.EqualTo(response));
        }
    }
}