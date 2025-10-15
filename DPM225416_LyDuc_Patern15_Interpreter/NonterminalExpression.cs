namespace Interpreter.Structural
{
    /// <summary>
    /// The 'NonterminalExpression' class
    /// </summary>

    public class NonterminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("Called Nonterminal.Interpret()");
        }
    }
}
