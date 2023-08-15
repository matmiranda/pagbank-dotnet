namespace PagBank.Model
{
    public class Card
    {
        [JsonPropertyName("number"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Number { get; set; }
        [JsonPropertyName("exp_month"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ExpMonth { get; set; }
        [JsonPropertyName("exp_year"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ExpYear { get; set; }
        [JsonPropertyName("security_code"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SecuritCode { get; set; }
        [JsonPropertyName("holder"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Holder? Holder { get; set; }
        [JsonPropertyName("store"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Store { get; set; }
    }
}
