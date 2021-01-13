using System.Collections.Generic;
using Newtonsoft.Json;

namespace FaceitGraphs_backend.Models.DTO.Player.MatchHistory
{
    public class PlayerMatchesDTO
    {
        [JsonProperty("items")] public List<MatchDTO> Items { get; set; }

        [JsonProperty("start")] public long Start { get; set; }

        [JsonProperty("end")] public long End { get; set; }

        /// <summary> The timestamp (Unix time) as lower bound of the query. </summary>
        [JsonProperty("from")] public int From { get; set; }
        /// <summary> The timestamp (Unix time) as higher bound of the query. </summary>
        [JsonProperty("to")] public int To { get; set; }
    }
}