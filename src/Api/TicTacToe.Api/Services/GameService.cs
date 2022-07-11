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

        public Game Play(PlayRequestModel request)
        {
            s_game.Cells[request.Coordinates[0]][request.Coordinates[1]] = request.PlayerId;
            SetWinner(request);

                return s_game;
        }

        private void SetWinner(PlayRequestModel request)
        {

            CalculateCellVartically(request);
            CalculateCellHorizontally(request);
            CalculateCellCrossTopToDown(request);
            CalculateCellCrossDownToTop(request);
        }

        private void CalculateCellVartically(PlayRequestModel request)
        {
            var count = 0;
            int xAccess = request.Coordinates[0];
            int yAccess = request.Coordinates[1];

            for (int i = yAccess; (i > (yAccess - 5)) && (i > -1); i--)
            {
                if (s_game.Cells[xAccess][i] == request.PlayerId)
                    count++;
                else
                    break;
            }
            if (count == 5)
                return;
            for (int i = (yAccess + 1); (i <= (yAccess + 5)) && (i < 15); i++)
            {
                if (s_game.Cells[xAccess][i] == request.PlayerId)
                    count++;
                else
                    break;
            }
        }

        private void CalculateCellHorizontally(PlayRequestModel request)
        {
            //var count = 0;
            //int xAccess = request.Coordinates[0];
            //int yAccess = request.Coordinates[1];

            //for (int i = xAccess; (i > (xAccess - 5)) && (i > -1); i--)
            //{
            //    if (s_game.Cells[i][yAccess] == request.PlayerId)
            //        count++;
            //    else
            //        break;
            //}
            //if (count == 5)
            //    return;
            //for (int i = (xAccess + 1); (i <= (xAccess + 5)) && (i < 15); i++)
            //{
            //    if (s_game.Cells[i][yAccess] == request.PlayerId)
            //        count++;
            //    else
            //        break;
            //}
        }

        private void CalculateCellCrossTopToDown(PlayRequestModel request)
        {
            var count = 0;
            int xAccess = request.Coordinates[0];
            int yAccess = request.Coordinates[1];

            for (int j = yAccess, i = xAccess; (i > (xAccess - 5)) && (i > -1) && (j < 15); j++, i--)
            {
                if (s_game.Cells[i][j] == request.PlayerId)
                    count++;
                else
                    break;
            }
            if (count == 5)
                return;
            for (int j = (yAccess - 1), i = (xAccess + 1); (i <= (xAccess + 5)) && (i < 15) && (j > -1); j--, i++)
            {
                if (s_game.Cells[i][j] == request.PlayerId)
                    count++;
                else
                    break;
            }
        }

        private void CalculateCellCrossDownToTop(PlayRequestModel request)
        {
            var count = 0;
            int xAccess = request.Coordinates[0];
            int yAccess = request.Coordinates[1];

            for (int i = xAccess, j = yAccess; (j > (yAccess - 5)) && (j > -1) && (i < 15); i++, j--)
            {
                if (s_game.Cells[i][j] == request.PlayerId)
                    count++;
                else
                    break;
            }
            if (count == 5)
                return;
            for (int i = (xAccess - 1), j = (yAccess + 1); (j <= (yAccess + 5)) && (j < 15) && (i > -1); i--, j++)
            {
                if (s_game.Cells[i][j] == request.PlayerId)
                    count++;
                else
                    break;
            }
        }
    }
}
