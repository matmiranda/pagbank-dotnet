using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace PagBank.Service
{
    public class ConnectChallengeService
    {
        private readonly IPagBankSetting _pagBankConfig;

        public ConnectChallengeService(IPagBankSetting pagBankConfig)
        {
            _pagBankConfig = pagBankConfig;
        }

        private IRestClient RestClient
        {
            get
            {
                var MsgError = "RestClient is null. Make sure it's properly configured.";
                if (_pagBankConfig.RestClient is null)
                    throw new InvalidOperationException(MsgError);
                return _pagBankConfig.RestClient;
            }
        }

        //public async Task<RestResponse> CreateAsync<T>(PagBankRequest<T> pagBankRequest) where T : class
        //{
        //    var request = new RestRequest(pagBankRequest.PublicKeyEndpoint, RestSharp.Method.Get);
        //    if (pagBankRequest.Body != null)
        //        request.AddJsonBody(pagBankRequest.Body, ContentType.Json);
        //    request.AddOrUpdateHeader("accept", ContentType.Json);
        //    request.AddOrUpdateHeader("user-agent", PagBankUtil.GetUserAgent());
        //    if (pagBankRequest.Headers != null)
        //        foreach (var header in pagBankRequest.Headers)
        //            request.AddOrUpdateHeader(header.Key, header.Value);

        //    var response = await RestClient.ExecuteAsync(request);

        //    if (response.StatusCode == HttpStatusCode.OK)
        //    {
        //        var publicKeyResponse = JsonSerializer.Deserialize<PublicKeyResponse>(response.Content);

        //        // Passo 2: Decodificar e descriptografar o challenge
        //        var rsa = RSA.Create();
        //        rsa.ImportFromPem(pagBankRequest.PrivateKey.ToCharArray());

        //        byte[] encryptedChallenge = Convert.FromBase64String(publicKeyResponse.Challenge);
        //        byte[] decryptedChallenge = rsa.Decrypt(encryptedChallenge, RSAEncryptionPadding.OaepSHA256);

        //        string decodedChallenge = Encoding.Default.GetString(decryptedChallenge);

        //        // Agora você pode utilizar o decodedChallenge e o token gerado na sua próxima requisição
        //        Console.WriteLine("Decoded Challenge: " + decodedChallenge);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Erro ao obter a chave pública");
        //    }
        //}

        //class PublicKeyResponse
        //{
        //    public string Challenge { get; set; }
        //    public long CreatedAt { get; set; }
        //}
    }
}
