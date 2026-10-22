using static System.Console;

namespace MethodOverloading_DefaultParameters;

public class Program
{
    private static void Main()
    {
        WriteLine(ToMultiplicate(xInt: 3, 2));
        WriteLine(ToMultiplicate(xDouble: 56.4, 7));
        WriteLine(ToMultiplicate("Lyth_", 4));
    }

    private static int ToMultiplicate(int xInt, int n = 2)
    {
        return (int)ToMultiplicate(xDouble: xInt, n);
    }
    private static double ToMultiplicate(double xDouble, int n = 2)
    {
        return n * xDouble;
    }
    private static string ToMultiplicate(string xStr, int n = 2)
    {
        string result = xStr;

        for (int i = 1; i < n; i++)
        {
            result += xStr;
        }

        return result;
    }
}
