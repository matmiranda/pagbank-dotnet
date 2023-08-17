using Moq;
using PagBank;
using PagBank.Model;
using RestSharp;
using System.Net;

namespace PagBankTest
{
    public class Tests
    {
        [Test]
        public async Task ExemploBasicoSandBox() 
        {
            var client = new PagBankClient();
            client.WithBaseUrl(BaseUrl.Sandbox);
            client.WithMethod(PagBankMethod.Get);
            client.WithToken("your-token");
            client.WithResource("orders");
            var response = await client.ExecuteAsync();
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Unauthorized));

        }
        [Test]
        public async Task MockExemploBasico()
        {
            var body = new PagBankBody
            {
                ReferenceId = "",
                Description = "",
                DiscountAmount = 0,
                Scope = "",
                SetupFee = 0,
                Shipping = new Shipping
                {
                    Address = new Address
                    {
                        Street = "",
                        Number = "",
                        Complement = "",
                        Locality = "",
                        City = "",
                        RegionCode = "",
                        Country = "",
                        PostalCode = ""
                    },
                    AddressModifiable = true,
                    ServiceType = "",
                    Amount = 0,
                    Box = new Box
                    {
                        Dimensions = new Dimensions
                        {
                            Height = 0,
                            Length = 0,
                            Width = 0,
                        },
                        Weight = 0
                    },
                    Type = ""
                },
                ExpirationDate = DateTime.Now,
                SoftDescriptor = "",
                AdditionalAmount = 0,
                Site = "",
                LimitSubscriptions = 0,
                Amount = new Amount
                {
                    Value = 0,
                    Currency = ""
                },
                BillingCycles = 0,
                BusinessCategory = "",
                Charges = new List<Charge>
                {
                    new Charge
                    {
                        Amount = new Amount
                        {
                            Currency = "",
                            Value = 0
                        },
                        Splits = new Splits
                        {
                            Method = "",
                            Receivers = new List<Receiver>
                            {
                                new Receiver
                                {
                                    Account = new Account
                                    {
                                        Id = ""
                                    },
                                    Amount = new Amount
                                    {
                                        Value = 0,
                                        Currency = ""
                                    }
                                }
                            }
                        },
                        Description = "",
                        PaymentMethod = new PaymentMethod
                        {
                            Capture = true,
                            Card = new Card
                            {
                                ExpMonth = "",
                                SecuritCode = "",
                                Store = true,
                                ExpYear = "",
                                Holder = new Holder
                                {
                                    Name = ""
                                },
                                Number = ""
                            },
                            Installments = 0,
                            Type = ""
                        },
                        ReferenceId = ""
                    }
                },
                Code = "",
                Company = new Company
                {
                    Address = new Address { },
                    Name = "",
                    TaxId = "",
                    Phones = new List<Phone>
                    {
                        new Phone
                        {

                        }
                    }
                },
                Customer = new Customer
                {
                    Email = "",
                    Enabled = true,
                    Name = "",
                    TaxId = "",
                    Phone = new Phone
                    {
                        Area = 0,
                        Type = "",
                        Country = 0,
                        Number = 0
                    },
                    Phones = new List<Phone>
                    {
                        new Phone
                        {
                        }
                    }
                },
                CustomerModifiable = true,
                Email = new Email
                {
                    Customer = new Customer { },
                    Merchant = new Merchant
                    {
                        Enabled = true
                    }
                },
                GrantType = "",
                Interval = new Interval
                {
                    Length = 0,
                    Unit = ""
                },
                Items = new List<Item> {
                    new Item
                    {
                        Name = "",
                        Quantity = 0,
                        ReferenceId = "",
                        UnitAmount = 0
                    }
                },
                Logo = "",
                Name = "",
                NotificationUrls = new List<string> { "" },
                PaymentMethod = "",
                PaymentMethods = new List<PaymentMethods>
                {
                    new PaymentMethods
                    {
                        Brands = new List<string> { "" },
                        Type = new List<string> { "" }
                    }
                },
                PaymentMethodsConfigs = new List<PaymentMethodsConfigs>
                {
                    new PaymentMethodsConfigs
                    {
                        Brands = new List<string> { "" },
                        ConfigOptions = new List<ConfigOptions>
                        {
                            new ConfigOptions
                            {
                                Option = "",
                                Value = ""
                            }
                        },
                        Type = ""
                    }
                },
                Person = new Person
                {
                    Address = new Address { },
                    BirthDate = "",
                    MotherName = "",
                    Name = "",
                    Phones = new List<Phone> { },
                    TaxId = 0
                },
                RedirectUri = "",
                RedirectUrl = "",
                RefreshToken = "",
                ReturnUrl = "",
                Token = "",
                Type = "",
                Urls = new List<string> { "" },
                Trial = new Trial
                {
                    Days = 0,
                    Enabled = true,
                    HoldSetupFee = true
                },
                TosAccpetance = new TosAcceptance
                {
                    Date = DateTime.Now,
                    UserIp = ""
                }
            };

            var restClientMock = new Mock<IRestClient>();
            var restRequestMock = new Mock<RestRequest>();
            var restResponseMock = new RestResponse();
            restResponseMock.StatusCode = HttpStatusCode.InternalServerError;
            restResponseMock.Content = "Something unexpected happened. Please, contact the PagBank Team";
            restClientMock
                .Setup(x => x.ExecuteAsync(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(restResponseMock);
            var pagBankClient = new PagBankClient(restClientMock.Object, restRequestMock.Object);
            pagBankClient.WithBaseUrl(BaseUrl.Sandbox);
            pagBankClient.WithMethod(PagBankMethod.Post);
            pagBankClient.WithJsonBody(body);
            pagBankClient.WithToken("your-token");
            pagBankClient.WithResource("{seu-recurso}");
            pagBankClient.AddOrUpdateHeader("custom-header", "123");
            pagBankClient.WithClientId("your-client-id");
            pagBankClient.WithClientSecret("your-client-secret");
            var response = await pagBankClient.ExecuteAsync();
            Assert.That(response, Is.Not.Null);
        }
    }
}