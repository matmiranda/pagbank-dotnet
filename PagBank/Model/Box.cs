namespace PagBank.Model
{
    public class Box
    {
        [JsonPropertyName("dimensions"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dimensions? Dimensions { get; set; }
        [JsonPropertyName("weight"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Weight { get; set; }
    }
}
