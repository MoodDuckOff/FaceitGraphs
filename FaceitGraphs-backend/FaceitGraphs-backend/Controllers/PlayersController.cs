using System;
using System.Net.Http;
using System.Threading.Tasks;
using FaceitGraphs_backend.Helpers.Exceptions;
using FaceitGraphs_backend.Models.DTO.Player;
using FaceitGraphs_backend.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace FaceitGraphs_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly PlayersService _playersService;

        public PlayersController(PlayersService playersService)
        {
            _playersService = playersService;
        }

        //GET api/players/{id}
        [HttpGet("{playerId}")]
        public async Task<ActionResult<PlayerDTO>> GetById(string playerId)
        {
            try
            {
                return Ok(JsonConvert.SerializeObject(await _playersService.GetPlayerById(playerId)));
            }
            catch (RequestException re)
            {
                return StatusCode(re.HttpStatusCode, re.Message);
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }
        //GET api/players?nickname=123
        //GET api/players?game=123&gameplayerid=123
        [HttpGet]
        public async Task<ActionResult<PlayerDTO>> GetByParameters(string nickname, string game, string gamePlayerId)
        {
            try
            {
                return Ok(JsonConvert.SerializeObject(await _playersService.GetPlayerByParameters(nickname, game, gamePlayerId)));
            }
            catch (RequestException re)
            {
                return StatusCode(re.HttpStatusCode, re.Message);
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }
    }
}