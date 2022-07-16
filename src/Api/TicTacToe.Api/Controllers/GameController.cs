
using TicTacToe.Services;
using Microsoft.AspNetCore.Mvc;
using TicTacToe.Api.Models;
using System.Text.Json;

namespace TicTacToe.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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

        [HttpPost]
        [Route("Play")]
        public IActionResult Play(PlayRequestModel request)
        {
            Game game = _service.Play(request);
            return Ok(game);
        }
    }
}