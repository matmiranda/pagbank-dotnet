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
        public object? PaymentMethod { get; set; }
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
        [JsonPropertyName("expiration_date"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTimeOffset? ExpirationDate { get; set; }
        [JsonPropertyName("customer_modifiable"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? CustomerModifiable { get; set; }
        [JsonPropertyName("items"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Item>? Items { get; set; }
        [JsonPropertyName("additional_amount"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? AdditionalAmount { get; set; }
        [JsonPropertyName("discount_amount"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? DiscountAmount { get; set; }
        [JsonPropertyName("shipping"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Shipping? Shipping { get; set; }
        [JsonPropertyName("payment_methods"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<PaymentMethods>? PaymentMethods { get; set; }
        [JsonPropertyName("payment_methods_configs"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<PaymentMethodsConfigs>? PaymentMethodsConfigs { get; set; }
        [JsonPropertyName("soft_descriptor"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SoftDescriptor { get; set; }
        [JsonPropertyName("redirect_url"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? RedirectUrl { get; set; }
        [JsonPropertyName("return_url"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ReturnUrl { get; set; }
        [JsonPropertyName("notification_urls"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? NotificationUrls { get; set; }
        [JsonPropertyName("site"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Site { get; set; }
        [JsonPropertyName("redirect_uri"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? RedirectUri { get; set; }
        [JsonPropertyName("logo"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Logo { get; set; }
        [JsonPropertyName("grant_type"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? GrantType { get; set; }
        [JsonPropertyName("code"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Code { get; set; }
        [JsonPropertyName("scope"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Scope { get; set; }
        [JsonPropertyName("refresh_token"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? RefreshToken { get; set; }
        [JsonPropertyName("token"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Token { get; set; }
        [JsonPropertyName("charges"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Charge>? Charges { get; set; }
        [JsonPropertyName("qr_codes"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<QrCodes>? QrCodes { get; set; }
    }
}