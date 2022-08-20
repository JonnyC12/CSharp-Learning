using System.Diagnostics;
using snake;

Board board = new Board(20, 20);

Snake snake = new Snake(10, 10);

Apple apple = new Apple(0, 0);

bool eatenApple = false;

do
{
    Console.Clear();
    board.DrawBoard();
    // Move snake 
    snake.Move(eatenApple);

    // Check if snake it's apple 
    eatenApple = snake.EatApple(apple, board);

    // Draw snake 
    snake.DrawSnake();

    // If the board doesn't have Apple, we create an Apple
    if (!board.hasApple)
    {
        apple = Apple.CreateApple(snake, board);
    }

    // We drawing the apple in the board console
    apple.DrawApple();



    var sw = Stopwatch.StartNew();
    while (sw.ElapsedMilliseconds <= 100)
    {
        snake.Direction = Util.ReadMove(snake.Direction);
    }

} while (snake.CheckDie(board));


Util.Scores(snake);

Console.ReadKey();