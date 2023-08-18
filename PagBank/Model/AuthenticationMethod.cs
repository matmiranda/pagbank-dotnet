namespace PagBank.Model
{
    public class AuthenticationMethod
    {
        [JsonPropertyName("type"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Type { get; set; }
        [JsonPropertyName("id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Id { get; set; }
        [JsonPropertyName("cavv"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Cavv { get; set; }
        [JsonPropertyName("eci"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Eci { get; set; }
        [JsonPropertyName("xid"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Xid { get; set; }
        [JsonPropertyName("version"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Version { get; set; }
        [JsonPropertyName("dstrans_id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? DstransId { get; set; }
    }
}