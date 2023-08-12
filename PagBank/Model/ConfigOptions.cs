namespace PagBank.Model
{
    public class ConfigOptions
    {
        [JsonPropertyName("option"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Option { get; set; }
        [JsonPropertyName("value"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Value { get; set; }
    }
}
