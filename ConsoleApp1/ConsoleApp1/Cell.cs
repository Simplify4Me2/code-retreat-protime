namespace ConsoleApp1
{
    public class Cell
    {
        public Coordinates Coordinates { get; set; }

        public Cell()
        {
            Coordinates = new Coordinates
            {
                X = 0,
                Y = 0
            };
        }
    }

    public struct Coordinates
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}