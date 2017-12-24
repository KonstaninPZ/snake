using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Check
    {
        public static bool checkKoordEdge(CellSnake head) {

            if ((head.X > 0) && (head.X < 48) && (head.Y > 0) && (head.Y < 29))
            {
                    return true;
            }
            else
            {
                return false;
            }
        }
    }
}
