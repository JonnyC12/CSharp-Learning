namespace snake
{
    internal class Board
    {
        public readonly int Height;
        public readonly int Width;
        public bool hasApple;

        public Board(int Height, int Width)
        {
            this.Height = Height;
            this.Width = Width;
        }
        public void DrawBoard()
        {
            // Console.WriteLine("");
            // Drawing columss of board
            for (int i = 0; i < Height; i++)
            {
                Util.DrawPosition(Width, i, "#");
                Util.DrawPosition(0, i, "#");
            }
            // Drawing rows of board
            for (int i = 0; i < Width; i++)
            {
                Util.DrawPosition(i, Height, "#");
                Util.DrawPosition(i, 0, "#");
            }

        }
    }
}
