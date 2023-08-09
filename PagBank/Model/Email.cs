namespace PagBank
{
    public class Email
    {
        [JsonPropertyName("merchant"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Merchant? Merchant { get; set; }
        [JsonPropertyName("customer"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Customer? Customer { get; set; }
    }
}
