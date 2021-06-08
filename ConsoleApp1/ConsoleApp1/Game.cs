namespace ConsoleApp1
{
    public class Game
    {
        public Player PlayerOne { get; set; }

        public Player PlayerTwo { get; set; }

        public Board Board { get; set; }

        public Game()
        {
            this.PlayerOne = new Player('X');
            this.PlayerTwo = new Player('O');
        }
    }
}