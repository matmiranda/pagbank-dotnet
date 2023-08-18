namespace PagBank.Model
{
    public class Boleto
    {
        [JsonPropertyName("instruction_lines"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public InstructionLines? InstructionLines { get; set; }
        [JsonPropertyName("holder"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Holder? Holder { get; set; }
        [JsonPropertyName("due_date"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? DueDate { get; set; }
    }
}