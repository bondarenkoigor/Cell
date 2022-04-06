using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class SlowMove : IMove
    {
        public void MoveUp()
        {
            Console.WriteLine("Cell moves up slowly");
        }
        public void MoveDown()
        {
            Console.WriteLine("Cell moves down slowly");
        }
        public void MoveRight()
        {
            Console.WriteLine("Cell moves right slowly");
        }
        public void MoveLeft()
        {
            Console.WriteLine("Cell moves left slowly");
        }
    }
}
