using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class MoveSnake
    {
        public static void moveSnake(ConsoleKeyInfo key, Snake snake)
        {
            if (key.Key == ConsoleKey.LeftArrow)
            {
                moveLeft(snake);
            }
            if (key.Key == ConsoleKey.RightArrow)
            {
                moveRight(snake);
            }
            if (key.Key == ConsoleKey.UpArrow)
            {
                moveUp(snake);
            }
            if (key.Key == ConsoleKey.DownArrow)
            {
                moveDown(snake);
            }
            Console.Clear();
            GameField.writeGameField();
            snake.printSnake();
        }
        public static void moveRight( Snake snake)
        {
            for (int i = 0; i < snake.bodySnake.Count; i++)
            {
                if (i == snake.bodySnake.Count - 1)
                {
                    snake.bodySnake[i].X += 1;
                    continue;
                }
                    snake.bodySnake[i].X = snake.bodySnake[i + 1].X;
                    snake.bodySnake[i].Y = snake.bodySnake[i + 1].Y;
            }
        }
        public static void moveDown(Snake snake)
        {
            for (int i = 0; i < snake.bodySnake.Count; i++)
            {
                if (i == snake.bodySnake.Count - 1)
                {
                    snake.bodySnake[i].Y += 1;
                    continue;
                }
                snake.bodySnake[i].X = snake.bodySnake[i + 1].X;
                snake.bodySnake[i].Y = snake.bodySnake[i + 1].Y;
            }
        }
        public static void moveUp(Snake snake)
        {

            for (int i = 0; i < snake.bodySnake.Count ; i++)
            {
                    if (i == snake.bodySnake.Count - 1)
                    {
                        snake.bodySnake[i].Y -= 1;
                        continue;
                    }
                    snake.bodySnake[i].X = snake.bodySnake[i + 1].X;
                    snake.bodySnake[i].Y = snake.bodySnake[i + 1].Y;
            }
            
        }
        public static void moveLeft(Snake snake)
        {
            for (int i = 0; i < snake.bodySnake.Count; i++)
            {
                if (i == snake.bodySnake.Count-1)
                {
                    snake.bodySnake[i].X -= 1;
                    continue;
                }
                snake.bodySnake[i].X = snake.bodySnake[i + 1].X;
                snake.bodySnake[i].Y = snake.bodySnake[i + 1].Y;
            }
        }
    }
}
