using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
   static class WriteSnake
    {
        public static void WriteAt(int x, int y) {
            Console.SetCursorPosition(x, y);
            Console.Write('-');
        }
    }
}
