using System.Collections.Generic;
using Newtonsoft.Json;

namespace FaceitGraphs_backend.Models.DTO.Player.MatchHistory
{
    public class MatchResultsDTO
    {
        [JsonProperty("winner")] public string Winner { get; set; }

        [JsonProperty("score")] public IDictionary<string, int> Score { get; set; }
    }
}