namespace PagBank.Model
{
    public class QrCodes
    {
        [JsonPropertyName("amount"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Amount? Amount { get; set; }
        [JsonPropertyName("expiration_date"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTimeOffset? ExpirationDate { get; set; }
    }
}