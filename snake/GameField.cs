using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class GameField
    {
        public static int heightGameField = 50;
        public static int weightGameField = 30;

        public static void  writeGameField() {
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    if (i == 0 || i==29)
                    {
                        Console.Write("@");
                    }else if(j == 0 || j == 49)
                    {
                        Console.Write("@");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
