using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter name and size of your cell:");
            Cell yourCell = new(Console.ReadLine(), double.Parse(Console.ReadLine()), new Move(), new Attack(), new EatPlankton());
            Console.WriteLine("enter name and size of opponent cell:");
            Cell opponentCell = new(Console.ReadLine(), double.Parse(Console.ReadLine()), new Move(), new Attack(), new EatPlankton());

            yourCell.AttackOther(opponentCell);

            Console.WriteLine("\n\n");

            yourCell.ChangeMoveToFast();
            yourCell.MoveUp();
            yourCell.changeEatToPlankton();
            yourCell.Eat();
        }
    }
}
