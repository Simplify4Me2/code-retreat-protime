namespace TestProject1
{
    public class Board
    {
        public Cell[] Cells { get; set; }

        public Board()
        {
            this.Cells = new Cell[9];
        }
    }
}