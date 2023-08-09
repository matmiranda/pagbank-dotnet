namespace PagBank
{
    public class Amount
    {
        [JsonPropertyName("currency"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Currency { get; set; }
        [JsonPropertyName("value"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Value { get; set; }
    }
}
