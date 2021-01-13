using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FaceitGraphs_backend.Models.DTO.Player.MatchHistory
{
    public class MatchFactionDTO
    {
        [JsonProperty("team_id")] public string TeamId { get; set; }

        [JsonProperty("nickname")] public string Nickname { get; set; }

        [JsonProperty("avatar")] public Uri Avatar { get; set; }

        [JsonProperty("type")] public string Type { get; set; }

        [JsonProperty("players")] public IList<MatchPlayerDTO> Players { get; set; }
    }
}