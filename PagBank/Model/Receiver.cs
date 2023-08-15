namespace PagBank.Model
{
    public class Receiver
    {
        [JsonPropertyName("account"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Account? Account { get; set; }
        [JsonPropertyName("amount"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Amount? Amount { get; set; }
    }
}
