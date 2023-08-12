namespace PagBank.Model
{
    public class Address
    {
        [JsonPropertyName("street"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Street { get; set; }
        [JsonPropertyName("number"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Number { get; set; }
        [JsonPropertyName("complement"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Complement { get; set; }
        [JsonPropertyName("locality"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Locality { get; set; }
        [JsonPropertyName("postal_code"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PostalCode { get; set; }
        [JsonPropertyName("country"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Country { get; set; }
        [JsonPropertyName("region_code"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? RegionCode { get; set; }
        [JsonPropertyName("city"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? City { get; set; }
    }
}