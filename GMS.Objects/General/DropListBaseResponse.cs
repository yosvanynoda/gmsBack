using System.Text.Json.Serialization;

namespace GMS.Objects.General
{
    public class DropListBaseResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = "";
    }
}
