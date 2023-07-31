![example event parameter](https://github.com/matmiranda/pagbank-dotnet/actions/workflows/dotnet.yml/badge.svg?event=push)

## Como usar

Pacote Nuget [pagbank-dotnet](https://www.nuget.org/packages/pagbank-dotnet) ou execute o comando abaixo:

```
dotnet add package pagbank-dotnet --version
```

Documentação Oficial da [PagBank](https://dev.pagbank.uol.com.br/reference/introducao)

#### 1- Usando e instanciando PagBank

```c#
using PagBank;

private static string token = "123";
private static PagBankClient client = new(BaseUrl.Sandbox, token);
```

#### 1- Exemplo básico

```c#
var request = new PagBankRequest<object>
{
    Body = null,
    Headers = null,
    Method = Method.Get,
    Endpoint = "{seu_endpoint}"
};

var response = await client.ExecuteAsync(request);
```

#### 2 - Exemplo de criar o pedido

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

#### 3 - Exemplo de consultar pedidos

```c#
var request = new PagBankRequest<object>
{
    Method = Method.Get,
    Endpoint = "orders/ORDE_XXXXXXXX"
};

var response = await client.ExecuteAsync(request);
```