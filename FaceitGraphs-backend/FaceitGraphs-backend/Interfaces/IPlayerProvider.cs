using System.Threading.Tasks;
using FaceitGraphs_backend.Models.DTO.Player;

namespace FaceitGraphs_backend.Interfaces
{
    public interface IPlayerProvider
    { 
        Task<PlayerDTO> GetPlayerById(string playerId);
    }
}