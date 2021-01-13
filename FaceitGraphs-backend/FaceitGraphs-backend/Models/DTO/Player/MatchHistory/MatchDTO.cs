using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FaceitGraphs_backend.Models.DTO.Player.MatchHistory
{
    public class MatchDTO
    {
        private string _faceitUrl;
        [JsonProperty("match_id")] public string MatchId { get; set; }

        [JsonProperty("game_id")] public string GameId { get; set; }

        [JsonProperty("region")] public string Region { get; set; }

        [JsonProperty("match_type")] public string MatchType { get; set; }

        [JsonProperty("game_mode")] public string GameMode { get; set; }

        [JsonProperty("max_players")] public int MaxPlayers { get; set; }

        [JsonProperty("teams_size")] public int TeamsSize { get; set; }
        
        [JsonProperty("teams")] public IDictionary<string, MatchFactionDTO> Teams { get; set; }

        [JsonProperty("playing_players")] public List<string> PlayingPlayers { get; set; }

        [JsonProperty("competition_id")] public string CompetitionId { get; set; }

        [JsonProperty("competition_name")] public string CompetitionName { get; set; }

        [JsonProperty("competition_type")] public string CompetitionType { get; set; }

        [JsonProperty("organizer_id")] public string OrganizerId { get; set; }

        [JsonProperty("status")] public string Status { get; set; }
        /// <summary> Match started at (Unix time) </summary>
        [JsonProperty("started_at")] public int StartedAt { get; set; }
        /// <summary> Match finished at (Unix time) </summary>
        [JsonProperty("finished_at")] public int FinishedAt { get; set; }

        [JsonProperty("results")] public MatchResultsDTO MatchResultsDTO { get; set; }

        [JsonProperty("faceit_url")]
        public string FaceitUrl
        {
            get => _faceitUrl;
            set => _faceitUrl = value.Replace("{lang}", "en");
        }
    }
}