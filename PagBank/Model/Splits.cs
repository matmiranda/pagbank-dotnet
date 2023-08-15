namespace PagBank.Model
{
    public class Splits
    {
        [JsonPropertyName("method"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Method { get; set; }
        [JsonPropertyName("receivers"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Receiver>? Receivers { get; set; }
    }
}
