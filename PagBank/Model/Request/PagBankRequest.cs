namespace PagBank
{
    public class PagBankRequest
    {
        [JsonPropertyName("amount"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Amount? Amount { get; set; }
        [JsonPropertyName("interval"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Interval? Interval { get; set; }
        [JsonPropertyName("trial"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Trial? Trial { get; set; }
        [JsonPropertyName("payment_method"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? PaymentMethod { get; set; }
        [JsonPropertyName("name"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Name { get; set; }
        [JsonPropertyName("description"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Description { get; set; }
        [JsonPropertyName("setup_fee"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? SetupFee { get; set; }
        [JsonPropertyName("billing_cycles"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? BillingCycles { get; set; }
        [JsonPropertyName("limit_subscriptions"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? LimitSubscriptions { get; set; }
        [JsonPropertyName("email"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Email? Email { get; set; }
        [JsonPropertyName("urls"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Urls { get; set; }
    }
}
