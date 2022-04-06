using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Run : IFight
    {
        public void Fight(Cell other)
        {
            Console.WriteLine($"Cell runs away from {other.Name}");
        }
    }
}
