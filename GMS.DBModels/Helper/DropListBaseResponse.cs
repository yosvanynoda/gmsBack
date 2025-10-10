using System.Text.Json.Serialization;

namespace GMS.DBModels.Helper
{
    public class DropListBaseResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = "";
    }
}
