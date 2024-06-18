namespace SimUDuck._1_InitialDesign.Ducks
{
    public class RubberDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I'm a real Rubber duck");
        }

        public override void Fly()
        {
            Console.WriteLine("I can't fly");
        }

        public override void Quack()
        {
            Console.WriteLine("I'm squacking");
        }
    }
}
