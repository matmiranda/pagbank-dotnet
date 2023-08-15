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
    }
}
