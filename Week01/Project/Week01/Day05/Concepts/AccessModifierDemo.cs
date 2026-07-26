namespace Week01.Day05.Concepts;

public class AccessModifierDemo
{
    public int PublicValue = 10;

    private int PrivateValue = 20;

    protected int ProtectedValue = 30;

    internal int InternalValue = 40;

    public void Display()
    {
        Console.WriteLine($"Public    : {PublicValue}");
        Console.WriteLine($"Private   : {PrivateValue}");
        Console.WriteLine($"Protected : {ProtectedValue}");
        Console.WriteLine($"Internal  : {InternalValue}");
    }
}