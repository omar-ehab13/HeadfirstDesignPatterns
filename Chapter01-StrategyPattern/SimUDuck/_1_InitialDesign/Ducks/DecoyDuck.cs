namespace SimUDuck._1_InitialDesign.Ducks
{
    public class DecoyDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I'm a real Decoy duck");
        }

        public override void Fly()
        {
            Console.WriteLine("I can't fly");
        }

        public override void Quack()
        {
            Console.WriteLine("I can't quack");
        }
    }
}
