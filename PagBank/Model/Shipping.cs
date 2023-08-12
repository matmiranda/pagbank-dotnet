namespace PagBank.Model
{
    public class Shipping
    {
        [JsonPropertyName("type"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Type { get; set; }
        [JsonPropertyName("amount"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Amount { get; set; }
        [JsonPropertyName("service_type"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Service_type { get; set; }
        [JsonPropertyName("address"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Address? Address { get; set; }
        [JsonPropertyName("address_modifiable"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? AddressModifiable { get; set; }
        [JsonPropertyName("box"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Box? Box { get; set; }
    }
}
