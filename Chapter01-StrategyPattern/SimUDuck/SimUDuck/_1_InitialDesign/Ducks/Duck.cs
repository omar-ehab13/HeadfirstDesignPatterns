namespace SimUDuck._1_InitialDesign.Ducks
{
    public abstract class Duck
    {
        public abstract void Display();

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
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
