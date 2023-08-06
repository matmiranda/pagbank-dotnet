[![License](https://img.shields.io/badge/license-MIT-green)](./LICENSE)
![dotnet status](https://github.com/matmiranda/pagbank-dotnet/actions/workflows/dotnet.yml/badge.svg?event=push)
[![NuGet Badge](https://buildstats.info/nuget/pagbank-dotnet)](https://www.nuget.org/packages/pagbank-dotnet)

# pagbank-dotnet 🔰

Bem-vindo ao repositório da _**pagbank-dotnet**_! 

Esta biblioteca é uma solução poderosa para facilitar a integração de serviços RESTful em seus aplicativos .NET usando o RestSharp.

## Visão Geral

A _**pagbank-dotnet**_ foi desenvolvida para simplificar e agilizar a comunicação com APIs RESTful. Ela oferece recursos avançados e uma integração perfeita com o RestSharp para realizar operações assíncronas, processar dados, autenticar solicitações e muito mais.

## Principais Recursos

- Integração perfeita com o RestSharp para chamadas RESTful
- Suporte a autenticação segura e gerenciamento de tokens
- Operações assíncronas eficientes para não bloquear a thread principal
- Abstração de dados para simplificar o processamento de respostas
- Extensa documentação e exemplos práticos

## Instalação

Para começar a usar a iblioteca _**pagbank-dotnet**_, siga estas etapas simples:

1. Abra seu projeto .NET no Visual Studio ou em sua IDE preferida.
2. Use o Gerenciador de Pacotes NuGet para adicionar a biblioteca ao seu projeto:

   ```bash
   Install-Package pagbank-dotnet
   ```
## Documentação Oficial do PagBank

Para informações detalhadas sobre como usar a biblioteca _**pagbank-dotnet**_ em conjunto com as APIs do PagBank, consulte a nossa [Documentação Oficial](https://dev.pagbank.uol.com.br/reference/introducao).


## Exemplo de uso

```c#
using PagBank;

var config = new PagBankConfig
{
    BaseUrl = BaseUrl.Sandbox,
    Token = "123"
};

var client = new PagBankClient(config);

var request = new PagBankRequest<object>
{
    Body = //string ou seu objeto, da sua preferência,
    Method = Method.Get,
    Endpoint = "{seu_endpoint}"
};

var response = await client.ExecuteAsync(request);
```

#### Exemplo de criar o pedido

```c#
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

var request = new PagBankRequest<object>
{
    Body = body,
    Method = Method.Post,
    Endpoint = "orders"
};

var response = await client.ExecuteAsync(request);
```

#### Exemplo de consultar pedidos

```c#
var request = new PagBankRequest<object>
{
    Method = Method.Get,
    Endpoint = "orders/ORDE_XXXXXXXX"
};

var response = await client.ExecuteAsync(request);
```

## Testes Unitários Compatíveis

A biblioteca _**pagbank-dotnet**_ é compatível e funcional com testes unitários usando a biblioteca de mocking Moq. Isso permite que você crie testes robustos para garantir a qualidade e a estabilidade da sua aplicação. Veja um exemplo de como você pode testar um serviço utilizando Moq:

```c#
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

            // Configura o mock para retornar 'restResponse' 
            //quando o método 'ExecuteAsync' for chamado
            mockRestClient
                .Setup(x => x.ExecuteAsync(It.IsAny<RestRequest>(), default))
                .ReturnsAsync(restResponse);

            var config = new PagBankConfig 
            {
              BaseUrl = BaseUrl.Sandbox,
              Token = "123",
              RestClient = mockRestClient.Object
            };

            // Cria o client passando o cofnig
            var pagBankClient = new PagBankClient(config);

            // Chame o método que utiliza o método ExecuteAsync
            var response = await pagBankClient.ExecuteAsync(pagBankRequest);

            // Verifique o resultado
            Assert.That(restResponse, Is.EqualTo(response));
        }
    }
}
```

## Saiba mais

Para mais detalhes e exemplos detalhados, consulte nossa [Wiki](https://github.com/matmiranda/pagbank-dotnet/wiki).


## Contribua e Ajude a Melhorar

Nós valorizamos sua contribuição para tornar a biblioteca _**pagbank-dotnet**_ ainda melhor! 

Se você encontrar erros, problemas ou tiver ideias para melhorias, fique à vontade para:

- Abrir problemas (Issues) detalhados para relatar erros ou propor melhorias.
- Enviar pull requests (PRs) com suas contribuições e correções.
- Participar de discussões construtivas sobre o projeto.

Sua ajuda é fundamental para o sucesso contínuo da biblioteca!