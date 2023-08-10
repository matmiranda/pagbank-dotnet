namespace PagBank.Model
{
    public class Person
    {
        [JsonPropertyName("address"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Address? Address { get; set; }
        [JsonPropertyName("name"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Name { get; set; }
        [JsonPropertyName("birth_date"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? BirthDate { get; set; }
        [JsonPropertyName("mother_name"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? MotherName { get; set; }
        [JsonPropertyName("tax_id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public long? TaxId { get; set; }
        [JsonPropertyName("phones"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Phone>? Phones { get; set; }
    }
}
