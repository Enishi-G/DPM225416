namespace Interpreter.NetOptimized;

using static System.Console;

using System.Collections.Generic;

/// <summary>
/// Interpreter Design Pattern
/// </summary>
public class Program
{
    public static void Main()
    {
        // Construct the 'parse tree'
        List<Expression> tree = [ new ThousandExpression(), new HundredExpression(),
                                  new TenExpression(), new OneExpression() ];

        // Create the context (i.e. roman value)
        var roman = "MCMXXVIII";
        var context = new Context { Input = roman };

        // Interpret
        tree.ForEach(e => e.Interpret(context));

        WriteLine($"{roman} = {context.Output}");

        // Wait for user
        ReadKey();
    }
}

