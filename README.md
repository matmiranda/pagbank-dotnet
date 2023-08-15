# <img src="/Icon/pagbank.png" height="50" width="50"> pagbank-dotnet

[![License](https://img.shields.io/badge/license-MIT-green)](./LICENSE)
![dotnet status](https://github.com/matmiranda/pagbank-dotnet/actions/workflows/dotnet.yml/badge.svg?event=push)
[![NuGet Badge](https://buildstats.info/nuget/pagbank-dotnet)](https://www.nuget.org/packages/pagbank-dotnet)

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

## Ambiente disponíveis

Você pode interagir com as APIs do PagBank por meio de dois ambientes: Sandbox e Produção, veja exemplo da tabela abaixo:

| Ambiente              | Url                                           |
| -                     | -                                             |
| Sandbox               | https://sandbox.api.pagseguro.com             |
| SandboxSecure         | https://secure.sandbox.api.pagseguro.com      |
| SandboxSignature      | https://sandbox.api.assinaturas.pagseguro.com |
| Production            | https://api.pagseguro.com                     |
| ProductionSecure      | https://secure.api.pagseguro.com              |
| ProductionSignature   | https://api.assinaturas.pagseguro.com         |


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

## Testes Unitários Compatíveis

A biblioteca _**pagbank-dotnet**_ é compatível e funcional com testes unitários usando a biblioteca de mocking Moq. Isso permite que você crie testes robustos para garantir a qualidade e a estabilidade da sua aplicação. 

Veja um [exemplo](https://github.com/matmiranda/pagbank-dotnet/blob/main/PagBankTest/UnitTest1.cs) de como você pode testar um serviço utilizando Moq.

## Saiba mais

Para mais detalhes e exemplos detalhados, consulte nossa [Wiki](https://github.com/matmiranda/pagbank-dotnet/wiki).


## Contribua e Ajude a Melhorar

Nós valorizamos sua contribuição para tornar a biblioteca _**pagbank-dotnet**_ ainda melhor! 

Se você encontrar erros, problemas ou tiver ideias para melhorias, fique à vontade para:

- Abrir problemas (Issues) detalhados para relatar erros ou propor melhorias.
- Enviar pull requests (PRs) com suas contribuições e correções.
- Participar de discussões construtivas sobre o projeto.

Sua ajuda é fundamental para o sucesso contínuo da biblioteca!
