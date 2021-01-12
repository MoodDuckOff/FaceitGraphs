using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using FaceitGraphs_backend.Helpers;
using FaceitGraphs_backend.Helpers.Exceptions;
using FaceitGraphs_backend.Interfaces;
using FaceitGraphs_backend.Models.DTO.Player;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace FaceitGraphs_backend.Providers
{
    //player id 8a4d5062-7232-4c1d-970e-5389794c1d84
    public class PlayersProvider : IPlayerProvider
    {
        private readonly string _apiKey;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<PlayersProvider> _logger;

        public PlayersProvider(IHttpClientFactory httpClientFactory, IConfiguration configuration, ILogger<PlayersProvider> logger)
        {
            _httpClientFactory = httpClientFactory;
            _apiKey = configuration.GetSection("apiKey").Value;
            _logger = logger;
        }

        public async Task<PlayerDTO> RequestGetPlayerById(string playerId)
        {
            using var client = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get,
                $"https://open.faceit.com/data/v4/players/{playerId}");
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Authorization", $"Bearer {_apiKey}");
            var response = await client.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();
                
            if (!response.IsSuccessStatusCode)
            {
                _logger.Log(LogLevel.Error, content);
                throw new RequestException(content,(int) response.StatusCode);
            }
                
            return JsonConvert.DeserializeObject<PlayerDTO>(content);
        }

        public async Task<PlayerDTO> RequestGetPlayerByParameters(string playerName)
        {
            using var client = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get,
                "https://open.faceit.com/data/v4/players" +
                $"?nickname={playerName}");
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Authorization", $"Bearer {_apiKey}");
            var response = await client.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();
                
            if (!response.IsSuccessStatusCode)
            {
                _logger.Log(LogLevel.Error, content);
                throw new RequestException(content,(int) response.StatusCode);
            }
                
            return JsonConvert.DeserializeObject<PlayerDTO>(content);
        }

        public async Task<PlayerDTO> RequestGetPlayerByParameters(string game, string gamePlayerId)
        {
            using var client = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get,
                "https://open.faceit.com/data/v4/players" +
                $"?game={game}" +
                $"&game_player_id={gamePlayerId}");
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Authorization", $"Bearer {_apiKey}");
            var response = await client.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();
            
            if (!response.IsSuccessStatusCode)
            {
                _logger.Log(LogLevel.Error, content);
                throw new RequestException(content,(int) response.StatusCode);
            }
                
            return JsonConvert.DeserializeObject<PlayerDTO>(content);
        }
        
    }
}