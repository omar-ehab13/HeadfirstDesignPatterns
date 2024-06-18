namespace SimUDuck._2_DesignWithInterfaces.Ducks
{
    public abstract class Duck
    {
        public abstract void Display();

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
