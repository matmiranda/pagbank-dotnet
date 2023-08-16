namespace PagBank
{
    public class PagBankUtil
    {
        #pragma warning disable CS8602 // Desreferência de uma referência possivelmente nula.
        internal static string GetUserAgent()
        {
            var attribute = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>();            
            var version = attribute.InformationalVersion;
            return $"pagbank-dotnet/{version}";
        }
    }
}
