namespace PagBank
{
    public class CustomerPhone
    {
        [JsonPropertyName("country"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Country { get; set; }

        [JsonPropertyName("area"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Area { get; set; }

        [JsonPropertyName("number"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Number { get; set; }

        [JsonPropertyName("type"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Type { get; set; }
    }
}
