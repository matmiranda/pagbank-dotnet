namespace PagBank.Model
{
    public class PaymentMethods
    {
        [JsonPropertyName("type"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Type { get; set; }
        [JsonPropertyName("brands"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Brands { get; set; }
    }
}
