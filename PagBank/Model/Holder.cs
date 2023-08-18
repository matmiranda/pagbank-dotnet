namespace PagBank.Model
{
    public class Holder
    {
        [JsonPropertyName("name"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Name { get; set; }
        [JsonPropertyName("address"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Address? Address { get; set; }
        [JsonPropertyName("tax_id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TaxId { get; set; }
        [JsonPropertyName("email"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Email { get; set; }
    }
}