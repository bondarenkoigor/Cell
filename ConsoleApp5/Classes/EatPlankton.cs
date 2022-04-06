using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class EatPlankton : IEat
    {
        public void Eat()
        {
            Console.WriteLine("Cell eats plankton");
        }
    }
}
