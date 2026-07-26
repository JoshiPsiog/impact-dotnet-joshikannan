using Week03.PatternsLab.Services;

namespace Week03.PatternsLab.Demos;

public static class StaticInstanceDemo
{
    public static void Run()
    {
        Console.WriteLine("\n========== TASK 3.13 ==========\n");

        Console.WriteLine($"Factorial(5) : {MathHelper.Factorial(5)}");
        Console.WriteLine($"IsPrime(17) : {MathHelper.IsPrime(17)}");
        Console.WriteLine($"GCD(18,24) : {MathHelper.GCD(18, 24)}");

        OrderProcessor processor = new();

        processor.ProcessOrder();

        Console.WriteLine("\nInterface vs Abstract");
        Console.WriteLine("Interface -> Contract only.");
        Console.WriteLine("Abstract -> Can have implementation and state.");
    }
}