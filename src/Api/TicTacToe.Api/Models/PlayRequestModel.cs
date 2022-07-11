namespace TicTacToe.Api.Models
{
    public class PlayRequestModel
    {
        public int  PlayerId { get; set; } 
        public int[] Coordinates { get; set; }
    }
}
