using TicTacToe.Api.Models;

namespace TicTacToe.Services
{
    public class GameService : IGameService
    {
        private static Game s_game;
        private readonly IGameService _gameService;

        public Game InitializeGame()
        {
            s_game = new Game();
            return s_game;
        }
    }
}
