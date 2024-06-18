using SimUDuck._2_DesignWithInterfaces.Ducks.Interfaces;

namespace SimUDuck._2_DesignWithInterfaces.Ducks
{
    public class MallardDuck : Duck, IFlayable, IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("I'm a real Mallarad duck");
        }

        public virtual void Quack()
        {
            Console.WriteLine("I'm quacking!");
        }

        public virtual void Fly()
        {
            Console.WriteLine("I'm flying!!");
        }
    }
}
