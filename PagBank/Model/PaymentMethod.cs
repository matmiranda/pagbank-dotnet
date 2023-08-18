namespace PagBank.Model
{
    public class PaymentMethod
    {
        [JsonPropertyName("type"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Type { get; set; }
        [JsonPropertyName("installments"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Installments { get; set; }
        [JsonPropertyName("capture"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Capture { get; set; }
        [JsonPropertyName("card"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Card? Card { get; set; }
        [JsonPropertyName("authentication_method"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public AuthenticationMethod? AuthenticationMethod { get; set; }
        [JsonPropertyName("boleto"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Boleto? Boleto { get; set; }
        [JsonPropertyName("soft_descriptor"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SoftDescriptor { get; set; }
    }
}