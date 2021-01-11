using System.Collections.Generic;
using Newtonsoft.Json;

namespace FaceitGraphs_backend.Models.DTO.Player
{
    public class GameDTO
    {
        [JsonProperty("game_player_id")] public string GamePlayerId { get; set; }

        [JsonProperty("game_player_name")] public string GamePlayerName { get; set; }

        [JsonProperty("game_profile_id")] public string GameProfileId { get; set; }

        [JsonProperty("region")] public string Region { get; set; }

        [JsonProperty("regions")]
        [JsonExtensionData]
        public IDictionary<string, RegionDTO> Regions { get; set; }

        [JsonProperty("skill_level")] public int SkillLevel { get; set; }

        [JsonProperty("skill_level_label")] public string SkillLevelLabel { get; set; }

        [JsonProperty("faceit_elo")] public int FaceitElo { get; set; }
    }
}