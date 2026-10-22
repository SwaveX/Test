namespace Class_Rnd_Matrix_Get_Set_AccessMods_ctor;

public class Program
{
    private static void Main()
    {
        FunnyMatrix fm0 = new(n: 3, a: 14, b: 2000);

        fm0.ShowMatrix();
    }
}

public class FunnyMatrix
{
    private int[,] _matrix;
    private int A { get; set; }
    private int B { get; set; }

    /// <summary>
    /// 1D Size of matrix
    /// </summary>
    private int N { get; set; }


    public FunnyMatrix(int n, int a, int b)
    {
        A = a;
        B = b;

        N = n;

        _matrix = new int[N, N];

        FillMatrix(A, B);
    }

    private void FillMatrix(int minValue, int maxValue)
    {
        for (int row = 0; row < _matrix.GetLength(0); row++)
            for (int column = 0; column < _matrix.GetLength(1); column++)
                _matrix[row, column] = Random.Shared.Next(minValue, maxValue + 1);
    }

    public void ShowMatrix()
    {
        for (int row = 0; row < _matrix.GetLength(0); row++)
        {
            Separator(_matrix.GetLength(1), ConsoleColor.DarkYellow);

            for (int column = 0; column < _matrix.GetLength(1); column++)
            {
                /// Double '\t' and `7` are arbitrary.
                Print($" {_matrix[row, column]}\t\t".PadLeft(7), ConsoleColor.Blue);
            }

            Separator(_matrix.GetLength(1), ConsoleColor.DarkYellow);
        }
    }

    private void Separator(int amount = 1, ConsoleColor forecolor = ConsoleColor.White)
    {
        PrintLine();
        Console.ForegroundColor = forecolor;

        int amountOfDigits = B.ToString().Length;

        for (int i = 0; i < amount; i++)
        {
            Print(" ");

            for (int j = 0; j < amountOfDigits; j++)
            {
                Print("-", forecolor);
            }

            Print("\t");
        }

        Console.ResetColor();
        PrintLine();
    }
    private void Print(object? data = null, ConsoleColor forecolor = ConsoleColor.White)
    {
        Console.ForegroundColor = forecolor;
        Console.Write(data + " ");
        Console.ResetColor();
    }
    private void PrintLine(object? data = null, ConsoleColor forecolor = ConsoleColor.White)
    {
        Console.ForegroundColor = forecolor;
        Console.WriteLine(data);
        Console.ResetColor();
    }
}
