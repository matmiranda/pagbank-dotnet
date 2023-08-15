## Visão Geral

A _**pagbank-dotnet**_ foi desenvolvida para simplificar e agilizar a comunicação com APIs RESTful. Ela oferece recursos avançados e uma integração perfeita com o RestSharp para realizar operações assíncronas, processar dados, autenticar solicitações e muito mais.

## Principais Recursos

- Integração perfeita com o RestSharp para chamadas RESTful
- Suporte a autenticação segura e gerenciamento de tokens
- Operações assíncronas eficientes para não bloquear a thread principal
- Abstração de dados para simplificar o processamento de respostas
- Extensa documentação e exemplos práticos

## Documentação Oficial do PagBank

Para informações detalhadas sobre como usar a biblioteca _**pagbank-dotnet**_ em conjunto com as APIs do PagBank, consulte a nossa [Documentação Oficial](https://dev.pagbank.uol.com.br/reference/introducao).


## Exemplo de uso

```c#
using PagBank;

var client = new PagBankClient();
client.WithBaseUrl(BaseUrl.Sandbox);
client.WithMethod(PagBankMethod.Get);
client.WithToken("your-token");
client.WithResource("{seu_recurso}");
```

#### Exemplo de criar o pedido

```c#
var body = new PagBankBody
{
    Customer = new Customer
    {
        TaxId = "62046100077",
        Email = "teste@teste.com.br",
        Name = "Test"
    },
    ReferenceId = "1234"
};
client.WithBaseUrl(BaseUrl.Sandbox);
client.WithMethod(PagBankMethod.Post);
client.WithJsonBody(body);
client.WithToken("your-token");
client.WithResource("orders");
var response = await client.ExecuteAsync();
```

#### Exemplo de consultar pedidos

```c#
client.WithBaseUrl(BaseUrl.Sandbox);
client.WithMethod(PagBankMethod.Get);
client.WithToken("your-token");
client.WithResource("orders/ORDE_XXXXXXXX");
var response = await client.ExecuteAsync();
```
