using Newtonsoft.Json;

namespace FaceitGraphs_backend.Models.DTO.Player
{
    public class RegionDTO
    {
        [JsonProperty("selected_ladder_id")] public string SelectedLadderId { get; set; }
    }
}