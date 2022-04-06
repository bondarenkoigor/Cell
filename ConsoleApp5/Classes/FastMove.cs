using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class FastMove : IMove
    {
        public void MoveUp()
        {
            Console.WriteLine("Cell moves up fast");
        }
        public void MoveDown()
        {
            Console.WriteLine("Cell moves down fast");
        }
        public void MoveRight()
        {
            Console.WriteLine("Cell moves right fast");
        }
        public void MoveLeft()
        {
            Console.WriteLine("Cell moves left fast");
        }
    }
}
