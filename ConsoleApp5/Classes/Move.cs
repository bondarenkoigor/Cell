using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Move : IMove
    {
        public void MoveUp()
        {
            Console.WriteLine("Cell moves up");
        }
        public void MoveDown()
        {
            Console.WriteLine("Cell moves down");
        }
        public void MoveRight()
        {
            Console.WriteLine("Cell moves right");
        }
        public void MoveLeft()
        {
            Console.WriteLine("Cell moves left");
        }
    }
}
