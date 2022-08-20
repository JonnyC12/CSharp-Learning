namespace snake
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
    internal class Snake
    {
        private List<Position> Tail { get; set; }
        public Direction Direction { get; set; }


        public int Points { get; set; }
        public Snake(int x, int y)
        {
            Position posIni = new Position(x, y);
            Tail = new List<Position>() { posIni };
            Direction = Direction.Down;
            Points = 0;
        }
        public void DrawSnake()
        {
            foreach (var pos in Tail)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Util.DrawPosition(pos.x, pos.y, "x");
                Console.ResetColor();
            }
        }
        // we need board to check if snake be within the limits of board 
        public bool CheckDie(Board board)
        {
            // Take snake's head 
            Position firstPositionofSnake = Tail.First();
            // 
            bool isAlive = !((Tail.Count(a => a.x == firstPositionofSnake.x && a.y == firstPositionofSnake.y) > 1) || TouchLimitBoard(firstPositionofSnake, board));
            return isAlive;
        }
        private bool TouchLimitBoard(Position firstPosition, Board board)
        {
            return firstPosition.x == 0 || firstPosition.x == board.Width || firstPosition.y == 0 || firstPosition.y == board.Height;
        }
        public void Move(bool eatenApple)
        {
            List<Position> newTail = new List<Position>();
            newTail.Add(TakeNewFirstPosition());
            newTail.AddRange(Tail);
            if (!eatenApple)
            {
                newTail.Remove(newTail.Last());
            }
            Tail = newTail;

        }
        private Position TakeNewFirstPosition()
        {
            int x = Tail.First().x;
            int y = Tail.First().y;

            switch (Direction)
            {
                case Direction.Up:
                    y += -1;
                    break;
                case Direction.Down:
                    y += 1;
                    break;
                case Direction.Left:
                    x += -1;
                    break;
                case Direction.Right:
                    x += 1;
                    break;
            }
            return new Position(x, y);
        }
        public bool EatApple(Apple apple, Board board)
        {
            if (TouchApple(apple.Position.x, apple.Position.y))
            {
                Points += 10;
                board.hasApple = false;
                return true;
            }
            return false;
        }
        public bool TouchApple(int x, int y)
        {
            return Tail.Any(p => p.x == x && p.y == y);
        }
    }
}