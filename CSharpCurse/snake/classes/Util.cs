namespace snake
{
    static class Util
    {
        public static void DrawPosition(int x, int y, string character)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(character);
        }
        public static Direction ReadMove(Direction actualDirection)
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey().Key;
                if (key == ConsoleKey.UpArrow && actualDirection != Direction.Down)
                {
                    return Direction.Up;
                }
                else if (key == ConsoleKey.DownArrow && actualDirection != Direction.Up)
                {
                    return Direction.Down;
                }
                else if (key == ConsoleKey.LeftArrow && actualDirection != Direction.Right)
                {

                    return Direction.Left;
                }
                else if (key == ConsoleKey.RightArrow && actualDirection != Direction.Left)
                {
                    return Direction.Right;
                }
            }
            return actualDirection;
        }
        public static void Scores(Snake snake)
        {
            Console.Clear();
            Console.WriteLine($"Your points are: {snake.Points}");
        }
    }

}