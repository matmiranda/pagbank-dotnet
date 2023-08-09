using System.Security.Cryptography;

namespace PagBank
{
    public class PagBankUtil
    {
        internal static string GetUserAgent()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var attribute = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
            var version = attribute?.InformationalVersion;
            return $"pagbank-dotnet/{version}";
        }

        internal static (string publicKey, string privateKey) CreatePrivatePublicKeys()
        {
            // Gere um par de chaves (chave pública e privada)
            using var rsa = RSA.Create();
            // Tamanho da chave em bits
            rsa.KeySize = 2048;

            // Exporte a chave pública em formato SubjectPublicKeyInfo (SPKI)
            var publicKeyBytes = rsa.ExportSubjectPublicKeyInfo();

            // Exporte a chave privada em formato PKCS#8
            var privateKeyBytes = rsa.ExportPkcs8PrivateKey();

            var publicKeyBase64 = Convert.ToBase64String(publicKeyBytes);
            var privateKeyBase64 = Convert.ToBase64String(privateKeyBytes);
            return (publicKeyBase64, privateKeyBase64);
        }
    }
}
