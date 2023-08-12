namespace PagBank.Model
{
    public class PaymentMethodsConfigs
    {
        [JsonPropertyName("type"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Type { get; set; }
        [JsonPropertyName("brands"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Brands { get; set; }
        [JsonPropertyName("config_options"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<ConfigOptions>? ConfigOptions { get; set; }
    }
}
