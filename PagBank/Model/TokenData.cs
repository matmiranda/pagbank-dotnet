namespace PagBank.Model
{
    public class TokenData
    {
        [JsonPropertyName("requestor_id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? RequestorId { get; set; }
        [JsonPropertyName("wallet"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Wallet { get; set; }
        [JsonPropertyName("cryptogram"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Cryptogram { get; set; }
        [JsonPropertyName("ecommerce_domain"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? EcommerceDomain { get; set; }
        [JsonPropertyName("assurance_level"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? AssuranceLevel { get; set; }
    }
}