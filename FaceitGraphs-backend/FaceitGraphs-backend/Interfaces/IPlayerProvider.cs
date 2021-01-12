using System.Threading.Tasks;
using FaceitGraphs_backend.Models.DTO.Player;

namespace FaceitGraphs_backend.Interfaces
{
    public interface IPlayerProvider
    { 
        Task<PlayerDTO> RequestGetPlayerById(string playerId);
        Task<PlayerDTO> RequestGetPlayerByParameters(string playerName);
        Task<PlayerDTO> RequestGetPlayerByParameters(string game, string gamePlayerId);
    }
}