namespace TicTacToe.Api.Models
{
    public class Game
    {
        public Game()
        {
            Players = new List<Player>();
            Players.Add(new Player { Id = 1, Name = "Player 1" });
            Players.Add(new Player { Id = 2, Name = "Player 2" });
            ActivePlayer = Players[0];
            Cells = new int[15][];
            GenerateCells();
        }
        public List<Player> Players { get; set; }
        public Player ActivePlayer { get; set; }
        public int[][] Cells { get; set; }
        public Player? Winner { get; set; }
        private void GenerateCells()
        {
            for(int i = 0; i < 15; i++)
            {
                Cells[i] = new int[15];
            }
        }
    }
}
