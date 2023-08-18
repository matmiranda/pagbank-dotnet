namespace PagBank.Model
{
    public class InstructionLines
    {
        [JsonPropertyName("line_1"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Line1 { get; set; }
        [JsonPropertyName("line_2"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Line2 { get; set; }
    }
}