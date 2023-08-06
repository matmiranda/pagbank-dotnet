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

        internal static RestClientOptions RestClientOptions(PagBankConfig pagBankConfig)
        {
            var options = new RestClientOptions(pagBankConfig.BaseUrl.GetDescription());
            options.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(pagBankConfig.Token, "Bearer");
            return options;
        }
    }
}
