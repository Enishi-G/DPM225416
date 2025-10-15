namespace Strategy.Structural
{
    /// <summary>
    /// The 'Context' class
    /// </summary>

    public class Context
    {
        Strategy strategy;

        // Constructor

        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void ContextInterface()
        {
            strategy.AlgorithmInterface();
        }
    }
}
