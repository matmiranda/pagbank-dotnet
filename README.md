## Como usar

Instale o pacote com a última versão [pagbank-dotnet](https://www.nuget.org/packages/pagbank-dotnet)

Documentação PagBank [api reference](https://dev.pagbank.uol.com.br/reference/introducao)

#### 1- Exemplo básico

```C#
using PagBank.Client;
using PagBank.Enum;

var token = "123";
var endpoint = "{coloca_seu_endpoint}";
var client = new PagBankClient(BaseUrl.Sandbox, token);
var response = await client.GetAsync(endpoint);
```

#### 2 - Passando parâmetro header

```C#
var header = new Dictionary<string, string>();
header.Add("accept", "application/json");
var endpoint = "{coloca_seu_endpoint}";
var response = await client.GetAsync(endpoint, header);
```

#### 3 - Exemplo de como listar assinauras

```C#
var token = "123";
var endpoint = "payments";
var client = new PagBankClient(BaseUrl.SandboxSignature, token);
var response = await client.GetAsync(endpoint);
```