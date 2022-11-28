namespace lb51;

public class randomColor : Printer
{
    private Random random = new Random();
    public override void Print(string value)
    {
        var prevColor = Console.ForegroundColor;

        Console.ForegroundColor = (ConsoleColor)random.Next(0, 16);

        Console.WriteLine(value.GetType());

        Console.ForegroundColor = (ConsoleColor)random.Next(0, 16);

        base.Print(value);

        Console.ForegroundColor = prevColor;
    }
}