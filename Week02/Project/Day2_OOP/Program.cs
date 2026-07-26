using System;
using System.Collections.Generic;

//================ TASK 2.4 =================
abstract class Shape
{
    public abstract double CalculateArea();

    public void DisplayArea()
    {
        Console.WriteLine($"Area = {CalculateArea():F2}");
    }
}

class Circle : Shape
{
    public double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : Shape
{
    public double Length;
    public double Width;

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public override double CalculateArea()
    {
        return Length * Width;
    }
}

//================ TASK 2.5 =================
interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}

interface IDrawable
{
    void Draw();
}

class Square : IShape, IDrawable
{
    public double Side;

    public Square(double side)
    {
        Side = side;
    }

    public double CalculateArea() => Side * Side;

    public double CalculatePerimeter() => 4 * Side;

    public void Draw()
    {
        Console.WriteLine("Drawing Square");
    }
}

//================ TASK 2.6 =================
class Calculator
{
    public int Add(int a, int b) => a + b;

    public double Add(double a, double b) => a + b;

    public int Add(int a, int b, int c) => a + b + c;

    public int Add(params int[] numbers)
    {
        int sum = 0;

        foreach (var n in numbers)
            sum += n;

        return sum;
    }
}

class Logger
{
    public void Log()
    {
        Console.WriteLine("Base Logger");
    }
}

class FileLogger : Logger
{
    public new void Log()
    {
        Console.WriteLine("File Logger");
    }
}

//================ TASK 2.7 =================
class Money
{
    public decimal Amount;
    public string Currency;

    public Money(decimal amount, string currency)
    {
        Amount = amount;
        Currency = currency;
    }

    public static Money operator +(Money a, Money b)
    {
        if (a.Currency != b.Currency)
            throw new Exception("Currency mismatch.");

        return new Money(a.Amount + b.Amount, a.Currency);
    }

    public static bool operator >(Money a, Money b)
        => a.Amount > b.Amount;

    public static bool operator <(Money a, Money b)
        => a.Amount < b.Amount;

    public static bool operator ==(Money a, Money b)
        => a.Amount == b.Amount && a.Currency == b.Currency;

    public static bool operator !=(Money a, Money b)
        => !(a == b);

    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Amount, Currency);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("===== TASK 2.4 =====");

        Shape circle = new Circle(5);
        Shape rectangle = new Rectangle(10, 4);

        circle.DisplayArea();
        rectangle.DisplayArea();

        Console.WriteLine("Cannot create Shape object because it is abstract.");

        Console.WriteLine("\n===== TASK 2.5 =====");

        Square square = new Square(6);

        Console.WriteLine($"Area : {square.CalculateArea()}");
        Console.WriteLine($"Perimeter : {square.CalculatePerimeter()}");
        square.Draw();

        Console.WriteLine("\n===== TASK 2.6 =====");

        Calculator calculator = new Calculator();

        Console.WriteLine(calculator.Add(5, 3));
        Console.WriteLine(calculator.Add(2.5, 3.5));
        Console.WriteLine(calculator.Add(1, 2, 3));
        Console.WriteLine(calculator.Add(1, 2, 3, 4, 5));

        List<Shape> shapes = new List<Shape>()
        {
            new Circle(3),
            new Rectangle(5,2)
        };

        foreach (var s in shapes)
            Console.WriteLine($"Runtime Area : {s.CalculateArea():F2}");

        Logger logger = new Logger();
        logger.Log();

        FileLogger fileLogger = new FileLogger();
        fileLogger.Log();

        Logger hidden = new FileLogger();
        hidden.Log();

        Console.WriteLine("\n===== TASK 2.7 =====");

        Money m1 = new Money(1000, "INR");
        Money m2 = new Money(500, "INR");

        Money total = m1 + m2;

        Console.WriteLine($"Total : {total.Amount} {total.Currency}");

        Console.WriteLine(m1 > m2);
        Console.WriteLine(m1 < m2);
        Console.WriteLine(m1 == m2);

        try
        {
            Money usd = new Money(100, "USD");

            Money x = m1 + usd;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("\nShape cannot be instantiated because it is abstract.");
        Console.WriteLine("One class implements multiple interfaces.");
        Console.WriteLine("Method hiding uses 'new', overriding uses 'override'.");
    }
}