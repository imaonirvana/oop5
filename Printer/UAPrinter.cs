namespace Program;

public class UAPrinter: Printer
{
    public override void Print(string value)
    {
        var prevColor = Console.ForegroundColor;
        
        Console.ForegroundColor = ConsoleColor.Blue;
        
        Console.WriteLine(value.GetType());

        Console.ForegroundColor = ConsoleColor.Yellow;

        base.Print(value);
        
        Console.ForegroundColor = prevColor;
    }
}