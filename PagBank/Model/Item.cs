namespace PagBank.Model
{
    public class Item
    {
        [JsonPropertyName("reference_id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ReferenceId { get; set; }
        [JsonPropertyName("name"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Name { get; set; }
        [JsonPropertyName("quantity"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Quantity { get; set; }
        [JsonPropertyName("unit_amount"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? UnitAmount { get; set; }
    }
}
