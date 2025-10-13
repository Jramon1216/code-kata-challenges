using c_sharp_kata.Solutions;

namespace c_sharp_kata;

public class Program
{
    public static void Main(string[] args)
    {
        KataUser user = new();
        user.IncProgress(1);
        Console.WriteLine(user.rank);
        Console.WriteLine(user.progress);
    }
}
