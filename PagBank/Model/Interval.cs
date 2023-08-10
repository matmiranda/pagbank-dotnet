namespace PagBank.Model
{
    public class Interval
    {
        [JsonPropertyName("unit"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Unit { get; set; }
        [JsonPropertyName("length"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Length { get; set; }
    }
}
