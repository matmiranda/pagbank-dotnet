namespace PagBank.Model
{
    public class Company
    {
        [JsonPropertyName("address"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Address? Address { get; set; }
        [JsonPropertyName("name"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Name { get; set; }
        [JsonPropertyName("tax_id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TaxId { get; set; }
        [JsonPropertyName("phones"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Phone>? Phones { get; set; }
    }
}
