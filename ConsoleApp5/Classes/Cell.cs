using System;
namespace ConsoleApp5
{
    internal class Cell
    {
        public string Name { get; set; }
        public double Size { get; set; }

        private IMove Mover;
        private IFight Fighter;
        private IEat Eater;

        public Cell(string name, double size, IMove mover, IFight fighter, IEat eater)
        {
            Name = name;
            Size = size;
            Mover = mover;
            Fighter = fighter;
            Eater = eater;
        }

        public Cell() : this("cell", 10, new Move(), new Attack(), new EatPlankton()) { }
        public Cell[] Split()
        {
            if (Size <= 1) return null;
            Cell[] cells = new Cell[2];
            cells[0] = new Cell(Name + "1", Size / 2, Mover, Fighter, Eater);
            cells[1] = new Cell(Name + "2", Size / 2, Mover, Fighter, Eater);
            return cells;
        }
        public void MoveRight()
        {
            Mover.MoveRight();
        }
        public void MoveLeft()
        {
            Mover.MoveLeft();
        }
        public void MoveUp()
        {
            Mover.MoveUp();
        }
        public void MoveDown()
        {
            Mover.MoveDown();
        }


        public void ChangeMoveToSlow()
        {
            Mover = new SlowMove();
        }
        public void ChangeMoveToNormal()
        {
            Mover = new Move();
        }
        public void ChangeMoveToFast()
        {
            Mover = new FastMove();
        }

        public void AttackOther(Cell other)
        {
            if (other.Size <= Size) ChangeFightToAttack();
            else ChangeFightToRun();

            Fighter.Fight(other);
        }

        public void ChangeFightToAttack()
        {
            Fighter = new Attack();
        }
        public void ChangeFightToRun()
        {
            Fighter = new Run();
        }

        public void Eat()
        {
            Eater.Eat();
        }
        public void changeEatToPlankton()
        {
            Eater = new EatPlankton();
        }
        public void changeEatToCell()
        {
            Eater = new EatOtherCells();
        }
    }
}