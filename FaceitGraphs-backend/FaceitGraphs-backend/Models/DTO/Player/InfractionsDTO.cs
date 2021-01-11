using Newtonsoft.Json;

namespace FaceitGraphs_backend.Models.DTO.Player
{
    public class InfractionsDTO
    {
        [JsonProperty("afk")] public int AFK { get; set; }

        [JsonProperty("leaver")] public int Leaver { get; set; }

        [JsonProperty("qm_not_checkedin")] public int QmNotCheckedIn { get; set; }

        [JsonProperty("qm_not_voted")] public int QmNotVoted { get; set; }

        [JsonProperty("last_infraction_date")] public string LastInfractionDate { get; set; }
    }
}