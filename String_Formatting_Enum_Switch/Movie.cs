using System.Text;

namespace String_Formatting_Enum_Switch;

public class Movie
{
#region Properties

    public int Id { get; set; }
    public string Title { get; set; }
    public int ReleasedYear { get; set; }
    public Genre MovieGenre { get; set; }
    public long Views { get; set; }
    public long Likes { get; set; }

#endregion

#region Methods

    public double GetRating()
    {
        return Math.Sqrt(Math.Pow(Likes, 2) / Views);
    }

    public override string ToString()
    {
        StringBuilder sb = new();

        sb.AppendLine($"Id: {Id.ToString().PadLeft(4)}");
        sb.AppendLine($"Title: {Title.PadRight(15)}");
        sb.AppendLine($"Released Year: {ReleasedYear.ToString().PadRight(8)}");
        sb.AppendLine($"Genre: {MovieGenre.ToString().PadRight(12)}");
        sb.AppendLine($"Rating: {GetRating().ToString("F3").PadRight(8)}");

        return sb.ToString();
    }

#endregion
}
