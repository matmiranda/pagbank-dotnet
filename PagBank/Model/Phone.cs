namespace PagBank.Model
{
    public class Phone
    {
        [JsonPropertyName("country"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Country { get; set; }
        [JsonPropertyName("area"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Area { get; set; }
        [JsonPropertyName("number"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Number { get; set; }
    }
}
