
using TicTacToe.Services;
using Microsoft.AspNetCore.Mvc;
using TicTacToe.Api.Models;
using System.Text.Json;

namespace TicTacToe.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {

        private readonly IGameService _service;

        public GameController(IGameService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("Initialize")]
        public IActionResult Initialize()
        {
            Game game = _service.InitializeGame();
            return Ok(game);
        }

        //[HttpPost]
        //[Route("Start")]
        //public IActionResult Start(IEnumerable<BattleShip> ships)
        //{
        //    BattleShipGame game = _battleShipGameService.StartGame(ships);
        //    return Ok(game);
        //}

        //[HttpGet]
        //[Route("Target")]
        //public  IActionResult Target(int locationId)
        //{
        //    BattleShipGame game = _battleShipGameService.HitBattleShipByEachOther(locationId);
        //    return Ok(game);
        //}
    }
}