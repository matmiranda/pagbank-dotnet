namespace PagBank.Model
{
    public class Charge
    {
        [JsonPropertyName("reference_id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ReferenceId { get; set; }
        [JsonPropertyName("description"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Description { get; set; }
        [JsonPropertyName("amount"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Amount? Amount { get; set; }
        [JsonPropertyName("payment_method"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public PaymentMethod? PaymentMethod { get; set; }
        [JsonPropertyName("splits"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Splits? Splits { get; set; }
        [JsonPropertyName("notification_urls"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? NotificationUrls { get; set; }
    }
}
