namespace Command.NetOptimized;

using static System.Console;

/// <summary>
/// The 'Receiver' class
/// </summary>
public class Calculator
{
    private int current = 0;

    // Perform operation for given operator and operand
    public void Operation(char @operator, int operand)
    {
        switch (@operator)
        {
            case '+': current += operand; break;
            case '-': current -= operand; break;
            case '*': current *= operand; break;
            case '/': current /= operand; break;
        }
        WriteLine(
            "Current value = {0,3} (following {1} {2})",
            current, @operator, operand);
    }
}
