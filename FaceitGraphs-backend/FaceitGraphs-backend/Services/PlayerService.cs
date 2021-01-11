using FaceitGraphs_backend.Interfaces;
using Microsoft.Extensions.Logging;

namespace FaceitGraphs_backend.Services
{
    public class PlayerService
    {
        private readonly IPlayerProvider _playerProvider;
        private readonly ILogger<PlayerService> _logger;

        public PlayerService(IPlayerProvider playerProvider, ILogger<PlayerService> logger)
        {
            _playerProvider = playerProvider;
            _logger = logger;
        }
        
        
    }
}