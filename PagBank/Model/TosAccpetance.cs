namespace PagBank.Model
{
    public class TosAcceptance
    {
        [JsonPropertyName("user_ip"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? UserIp { get; set; }
        [JsonPropertyName("date"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTimeOffset? Date { get; set; }
    }
}
