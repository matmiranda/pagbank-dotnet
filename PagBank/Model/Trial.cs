namespace PagBank.Model
{
    public class Trial
    {
        [JsonPropertyName("enabled"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Enabled { get; set; }
        [JsonPropertyName("hold_setup_fee"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? HoldSetupFee { get; set; }
        [JsonPropertyName("days"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Days { get; set; }
    }
}
