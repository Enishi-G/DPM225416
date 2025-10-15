namespace Flyweight.Structural
{
    /// <summary>
    /// The 'UnsharedConcreteFlyweight' class
    /// </summary>

    public class UnsharedConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("UnsharedConcreteFlyweight: " +
                extrinsicstate);
        }
    }
}

