namespace snake
{
    internal class Apple
    {
        public Position Position { get; set; }

        public Apple(int x, int y)
        {
            Position = new Position(x, y);
        }
        public void DrawApple()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Util.DrawPosition(Position.x, Position.y, "O");
            Console.ResetColor();
        }

        public static Apple CreateApple(Snake snake, Board board)
        {
            bool validApple;
            int x, y;
            do
            {
                Random rand = new Random();
                x = rand.Next(1, board.Height - 1);
                y = rand.Next(1, board.Width - 1);
                validApple = snake.TouchApple(x, y);
            } while (validApple);
            board.hasApple = true;
            return new Apple(x, y);
        }

    }
}