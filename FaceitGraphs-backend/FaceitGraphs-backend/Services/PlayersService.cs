using System;
using System.Threading.Tasks;
using FaceitGraphs_backend.Helpers.Exceptions;
using FaceitGraphs_backend.Interfaces;
using FaceitGraphs_backend.Models.DTO.Player;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace FaceitGraphs_backend.Services
{
    public class PlayersService
    {
        private readonly IPlayerProvider _playerProvider;
        private readonly ILogger<PlayersService> _logger;

        public PlayersService(IPlayerProvider playerProvider, ILogger<PlayersService> logger)
        {
            _playerProvider = playerProvider;
            _logger = logger;
        }

        public async Task<PlayerDTO> GetPlayerById(string playerId)
        {
            if (string.IsNullOrWhiteSpace(playerId))
                throw new RequestException("Empty player id", StatusCodes.Status400BadRequest);
            return await _playerProvider.RequestGetPlayerById(playerId);
        }

        public async Task<PlayerDTO> GetPlayerByParameters(string nickname, string game, string gamePlayerId)
        {
            if (!string.IsNullOrWhiteSpace(nickname))
                return await _playerProvider.RequestGetPlayerByParameters(nickname);
            if (!string.IsNullOrWhiteSpace(game) && !string.IsNullOrWhiteSpace(gamePlayerId))
                return await _playerProvider.RequestGetPlayerByParameters(game, gamePlayerId);
            throw new RequestException("You must specify a 'nickname' parameter or 'game' and 'game_player_id' parameters", StatusCodes.Status400BadRequest);
        }
    }
}