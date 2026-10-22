using static System.Console;

namespace In_out_ref_params_default_values;

public class Program
{
    private static void Main()
    {
        int number = 10;

        ForegroundColor = ConsoleColor.Cyan;
        A(in number);
        WriteLine($" After A: {number}\n");


        ForegroundColor = ConsoleColor.Green;
        B(out number);
        WriteLine($" After B: {number}\n");


        ForegroundColor = ConsoleColor.Blue;
        C(ref number);
        WriteLine($" After C: {number}\n");


        ForegroundColor = ConsoleColor.DarkYellow;
        WriteLine($" Sum: {SumValues(1, 2, 3, 4, 5)}\n");


        ForegroundColor = ConsoleColor.White;
        WriteLine($" Sum with array: {SumValues( [ 10, 20, 30 ] )}\n");
    }

    private static void A(in int value)
    {
        WriteLine($" A (in): {value}");
        WriteLine($" Impossible to update the value {value}");
    }

    private static void B(out int value)
    {
        value = 20;
        WriteLine($" B (out): {value}");
        WriteLine($" The value must be assigned before leaving the scope");
    }

    private static void C(ref int value)
    {
        value += 10;
        WriteLine($" C (ref): {value}");
        WriteLine(" The value is changed out of the scope");
    }

    private static int SumValues(params int[] values)
    {
        int sum = 0;

        foreach (int value in values)
        {
            sum += value;
        }

        return sum;
    }
}
