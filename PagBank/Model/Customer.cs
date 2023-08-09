namespace PagBank
{
    public class Customer
    {
        [JsonPropertyName("enabled"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Enabled { get; set; }
        [JsonPropertyName("name"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Name { get; set; }

        [JsonPropertyName("email"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Email { get; set; }

        [JsonPropertyName("tax_id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TaxId { get; set; }

        [JsonPropertyName("phones"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<CustomerPhone>? Phones { get; set; }
    }
}
