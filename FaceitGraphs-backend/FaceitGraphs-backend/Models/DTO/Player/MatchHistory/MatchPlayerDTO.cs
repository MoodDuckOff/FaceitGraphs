using System;
using Newtonsoft.Json;

namespace FaceitGraphs_backend.Models.DTO.Player.MatchHistory
{
    public class MatchPlayerDTO
    {
        private string _faceitUrl;
        [JsonProperty("player_id")] public string PlayerId { get; set; }

        [JsonProperty("nickname")] public string Nickname { get; set; }

        [JsonProperty("avatar")] public Uri Avatar { get; set; }

        [JsonProperty("skill_level")] public int SkillLevel { get; set; }

        [JsonProperty("game_player_id")] public string GamePlayerId { get; set; }

        [JsonProperty("game_player_name")] public string GamePlayerName { get; set; }

        [JsonProperty("faceit_url")]
        public string FaceitUrl
        {
            get => _faceitUrl;
            set => _faceitUrl = value.Replace("{lang}", "en");
        }
    }
}