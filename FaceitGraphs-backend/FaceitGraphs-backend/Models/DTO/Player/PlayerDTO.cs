using System.Collections.Generic;
using Newtonsoft.Json;

namespace FaceitGraphs_backend.Models.DTO.Player
{
    public class PlayerDTO
    {
        [JsonProperty("player_id")] public string PlayerId { get; set; }

        [JsonProperty("nickname")] public string Nickname { get; set; }

        [JsonProperty("avatar")] public string Avatar { get; set; }

        [JsonProperty("country")] public string Country { get; set; }

        [JsonProperty("cover_image")] public string CoverImage { get; set; }

        [JsonProperty("cover_featured_image")] public string CoverFeaturedImage { get; set; }

        [JsonProperty("infractions")] public InfractionsDTO InfractionsDTO { get; set; }

        [JsonProperty("platforms")]
        [JsonExtensionData]
        public IDictionary<string, string> Platforms { get; set; }

        [JsonProperty("games")]
        [JsonExtensionData]
        public IDictionary<string, GameDTO> Games { get; set; }

        [JsonProperty("settings")] public SettingsDTO SettingsDTO { get; set; }

        [JsonProperty("friends_ids")] public IList<string> FriendsIds { get; set; }

        [JsonProperty("bans")]
        [JsonExtensionData]
        public IList<IDictionary<string, string>> Bans { get; set; }

        [JsonProperty("new_steam_id")] public string NewSteamId { get; set; }

        [JsonProperty("steam_id_64")] public string SteamId64 { get; set; }

        [JsonProperty("steam_nickname")] public string SteamNickname { get; set; }

        [JsonProperty("membership_type")] public string MembershipType { get; set; }

        [JsonProperty("memberships")] public IList<string> Memberships { get; set; }

        [JsonProperty("faceit_url")] public string FaceitUrl { get; set; }
    }
}