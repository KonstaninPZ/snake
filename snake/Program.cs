using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Snake snake = new Snake();
            GameField.writeGameField();
            snake.printSnake();
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey();
                
                MoveSnake.moveSnake(key, snake);
                if (!Check.checkKoordEdge(snake.bodySnake[snake.bodySnake.Count-1])) {
                    break;
                }

            } while (key.Key != ConsoleKey.Escape);
            Console.WriteLine("Finish!!");

            Console.ReadLine();
        }
    }


}
