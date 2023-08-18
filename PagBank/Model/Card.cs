namespace PagBank.Model
{
    public class Card
    {
        [JsonPropertyName("number"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Number { get; set; }
        [JsonPropertyName("exp_month"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? ExpMonth { get; set; }
        [JsonPropertyName("exp_year"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? ExpYear { get; set; }
        [JsonPropertyName("security_code"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SecuritCode { get; set; }
        [JsonPropertyName("holder"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Holder? Holder { get; set; }
        [JsonPropertyName("store"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Store { get; set; }
        [JsonPropertyName("token_data"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public TokenData? Token_data { get; set; }
        [JsonPropertyName("id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Id { get; set; }
        [JsonPropertyName("encrypted"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Encrypted { get; set; }
        [JsonPropertyName("network_token"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? NetworkToken { get; set; }
    }
}