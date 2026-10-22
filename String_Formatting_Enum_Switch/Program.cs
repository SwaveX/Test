namespace String_Formatting_Enum_Switch;

public class Program
{
    private static void Print(object? data = null, ConsoleColor forecolor = ConsoleColor.White)
    {
        Console.ForegroundColor = forecolor;
        Console.Write(data);
        Console.ResetColor();
    }

    private static void PrintLine(object? data = null, ConsoleColor forecolor = ConsoleColor.White)
    {
        Console.ForegroundColor = forecolor;
        Console.WriteLine(data);
        Console.ResetColor();
    }

    private static void Main()
    {
        int movieAmount = ReadInt("Input the amount of movies to log: ");

        List<Movie> movieList = new();

        for ( int i = 0; i < movieAmount; i++)
        {
            Movie movie = new();

            PrintLine("\n---", ConsoleColor.Blue);

            movie.Id = ReadInt("Id: ");
            movie.Title = ReadString("Title: ");
            movie.ReleasedYear = ReadInt("Released year: ");
            movie.MovieGenre = ReadGenre("Genre: ");
            movie.Views = ReadLong("Views: ");
            movie.Likes = ReadLong("Likes: ");

            movieList.Add(movie);
        }

        PrintLine("\n\n");

        foreach (Movie movie in movieList)
        {
            PrintLine(movie, ConsoleColor.Green);

            PrintLine("\n");
        }        
    }

    #region ReadingHelpers

    private static int ReadInt(string message)
    {
        while (true)
        {
            Print(message);

            if ( int.TryParse(Console.ReadLine(), out int value) )
            {
                return value;
            }

            PrintLine("Incorrect value! Try again.\n", ConsoleColor.DarkRed);
        }
    }

    private static long ReadLong(string message)
    {
        while (true)
        {
            Print(message);

            if ( long.TryParse(Console.ReadLine(), out long value) )
            {
                return value;
            }

            PrintLine("Incorrect value! Try again.\n", ConsoleColor.DarkRed);
        }
    }

    private static Genre ReadGenre(string message)
    {
        while (true)
        {
            Print(message);
#if V1
            if ( int.TryParse(Console.ReadLine(), out int value))
            {
                switch (value)
                {
                    case 1:
                        return (Genre)1;

                    case 2:
                        return (Genre)2;

                    case 3:
                        return (Genre)3;

                    case 4:
                        return (Genre)4;

                    case 5:
                        return (Genre)5;
                    default:
                        PrintLine("Invalid genre! Try again.\n", ConsoleColor.DarkRed);
                        break;
                }
            }
#elif !V2
            if ( int.TryParse(Console.ReadLine(), out int value) 
                && Enum.IsDefined( typeof(Genre), value) )
            {
                return (Genre)value;
            }
#endif
            PrintLine("Invalid genre! Try again.\n", ConsoleColor.DarkRed);
        }
    }

    private static string ReadString(string message)
    {
        while (true)
        {
            Print(message);

            string? value = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(value))
            {
                return value;
            }

            PrintLine("Input cannot be empty! Try again.\n", ConsoleColor.DarkRed);
        }
    }
    
    #endregion
}
