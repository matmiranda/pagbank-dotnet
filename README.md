## Como usar

Instale o pacote com a última versão [pagbank-dotnet](https://www.nuget.org/packages/pagbank-dotnet)

#### 1- Exemplo básico

```C#
using PagBank.Client;
using PagBank.Enum;

static readonly string token = "123";
private readonly PagBankClient client = new(BaseUrl.Sandbox, token);

var response = await client.GetAsync("{seu_endpoint}");
```

#### 2 - Passando parâmetro header

```C#
var header = new Dictionary<string, string>();
header.Add("accept", "application/json");

var response = await client.GetAsync("{seu_endpoint}", header);
```