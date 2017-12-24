using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Snake
    {
       public List<CellSnake> bodySnake = new List<CellSnake>();

        public Snake(){
            for (int i = 1; i < 6; i++) {
                CellSnake cell = new CellSnake(i, 1);
                bodySnake.Add(cell);
            }
        }



        public void printSnake() {
            foreach (CellSnake item in bodySnake)
            {
                WriteSnake.WriteAt(item.X, item.Y);
            }
        }

        public void moveSnake(ConsoleKeyInfo key) {
            
        }
        
    }
}
