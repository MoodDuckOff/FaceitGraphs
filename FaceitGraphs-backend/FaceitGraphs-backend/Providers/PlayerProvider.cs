using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using FaceitGraphs_backend.Interfaces;
using FaceitGraphs_backend.Models.DTO.Player;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace FaceitGraphs_backend.Providers
{
    //player id 8a4d5062-7232-4c1d-970e-5389794c1d84
    public class PlayerProvider : IPlayerProvider
    {
        private readonly string _apiKey;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<PlayerProvider> _logger;

        public PlayerProvider(IHttpClientFactory httpClientFactory, IConfiguration configuration, ILogger<PlayerProvider> logger)
        {
            _httpClientFactory = httpClientFactory;
            _apiKey = configuration.GetSection("apiKey").Value;
            _logger = logger;
        }

        public async Task<PlayerDTO> GetPlayerById(string playerId)
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
                throw new Exception(content);
            }
                
            return JsonConvert.DeserializeObject<PlayerDTO>(content);
        }
    }
}