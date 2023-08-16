using Moq;
using PagBank;
using PagBank.Model;
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
            var body = new PagBankBody();
            var customer = new Customer();
            var phones = new List<Phone>();
            var item = new Item();
            var items = new List<Item>();
            var phone = new Phone();
            var charge = new Charge();
            var address = new Address();
            var charges = new List<Charge>();
            var paymentMethod = new PaymentMethod();
            var card = new Card();
            var holder = new Holder();

            body.ReferenceId = "referencia do pedido";
            customer.Name = "Jose da Silva";
            customer.Email = "email@test.com";
            customer.TaxId = "12345678909";
            phone.Area = 11;
            phone.Number = 999999999;
            phone.Type = "MOBILE";
            customer.Phone = phone;
            item.ReferenceId = "referencia do item";
            item.Name = "nome do item";
            item.Quantity = 1;
            item.UnitAmount = 10000;
            charge.ReferenceId = "referencia do pagamento";
            charge.Description = "descricao do pagamento";
            charge.Amount = new Amount { Value = 10000, Currency = "BRL" };
            paymentMethod.Type = "CREDIT_CARD";
            paymentMethod.Installments = 1;
            card.Number = "4111111111111111";
            card.ExpMonth = "12";
            card.ExpYear = "2026";
            card.SecuritCode = "123";
            holder.Name = "Jose da Silva";
            card.Holder = holder;
            paymentMethod.Card = card;
            paymentMethod.Capture = true;
            charge.PaymentMethod = paymentMethod;
            items.Add(item);
            charges.Add(charge);
            address.Street = "Avenida Brigadeiro Faria Lima";
            address.Number = "1384";
            address.Complement = "apto 12";
            address.Locality = "Pinheiros";
            address.City = "São Paulo";
            address.RegionCode = "SP";
            address.Country = "BRA";
            address.PostalCode = "01452002";
            customer.Phones = phones;
            body.Customer = customer;
            body.Items = items;
            body.Charges = charges;
            body.Shipping = new Shipping { Address = address };
            body.NotificationUrls = new List<string> { "https://meusite.com/notificacoes" };
            body.Charges = charges;
            body.Trial = new Trial { Enabled = true, HoldSetupFee = false };
            body.TosAccpetance = new TosAcceptance { Date = DateTime.Now, UserIp = "1" };

            var client = new PagBankClient();
            client.WithBaseUrl(BaseUrl.Sandbox);
            client.WithMethod(PagBankMethod.Get);
            client.WithToken("your-token");
            client.WithResource("{seu-recurso}");
            client.WithJsonBody(body);
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