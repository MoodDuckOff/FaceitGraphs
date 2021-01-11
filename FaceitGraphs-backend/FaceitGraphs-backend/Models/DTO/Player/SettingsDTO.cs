using Newtonsoft.Json;

namespace FaceitGraphs_backend.Models.DTO.Player
{
    public class SettingsDTO
    {
        [JsonProperty("language")] public string Language { get; set; }
    }
}