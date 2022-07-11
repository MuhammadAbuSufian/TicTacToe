
using TicTacToe.Api.Models;

namespace TicTacToe.Services
{
    public interface IGameService
    {
        public Game InitializeGame();
        public Game Play(PlayRequestModel request);
    }
}
