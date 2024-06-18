using SimUDuck._2_DesignWithInterfaces.Ducks.Interfaces;

namespace SimUDuck._2_DesignWithInterfaces.Ducks
{
    public class RubberDuck : Duck, IFlayable
    {
        public override void Display()
        {
            Console.WriteLine("I'm a real Rubber duck");
        }

        public void Fly()
        {
            Console.WriteLine("I'm squacking!");
        }
    }
}
