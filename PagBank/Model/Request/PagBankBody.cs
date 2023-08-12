namespace PagBank
{
    public class PagBankBody
    {
        [JsonPropertyName("customer"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Customer? Customer { get; set; }
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
        public object? Email { get; set; }
        [JsonPropertyName("urls"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Urls { get; set; }
        [JsonPropertyName("reference_id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ReferenceId { get; set; }
        [JsonPropertyName("type"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Type { get; set; }
        [JsonPropertyName("person"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Person? Person { get; set; }
        [JsonPropertyName("company"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Company? Company { get; set; }
        [JsonPropertyName("tos_acceptance"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public TosAcceptance? TosAccpetance { get; set; }
        [JsonPropertyName("business_category"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? BusinessCategory { get; set; }        
    }
}
