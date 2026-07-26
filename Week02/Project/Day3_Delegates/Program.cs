using System;
using System.Collections.Generic;

//================ TASK 2.8 =================
delegate double MathOperation(double a, double b);

class Calculator
{
    public static double Add(double a, double b)
    {
        double result = a + b;
        Console.WriteLine($"Add : {result}");
        return result;
    }

    public static double Subtract(double a, double b)
    {
        double result = a - b;
        Console.WriteLine($"Subtract : {result}");
        return result;
    }

    public static double Multiply(double a, double b)
    {
        double result = a * b;
        Console.WriteLine($"Multiply : {result}");
        return result;
    }

    public static double Divide(double a, double b)
    {
        double result = a / b;
        Console.WriteLine($"Divide : {result}");
        return result;
    }
}

//================ TASK 2.9 =================
class AlarmEventArgs : EventArgs
{
    public DateTime AlarmTime { get; set; }
}

class AlarmClock
{
    public event EventHandler<AlarmEventArgs>? OnAlarmRing;

    public void RingAlarm()
    {
        Console.WriteLine("\nAlarm Ringing...");
        OnAlarmRing?.Invoke(this, new AlarmEventArgs
        {
            AlarmTime = DateTime.Now
        });
    }
}

class Person
{
    public void WakeUp(object? sender, AlarmEventArgs e)
    {
        Console.WriteLine($"Person woke up at {e.AlarmTime:T}");
    }
}

class CoffeeMachine
{
    public void StartCoffee(object? sender, AlarmEventArgs e)
    {
        Console.WriteLine($"Coffee machine started at {e.AlarmTime:T}");
    }
}

//================ TASK 2.10 =================
class Processor
{
    public static void ProcessList(
        List<int> list,
        Predicate<int> predicate,
        Func<int, int> transform,
        Action<int> output)
    {
        foreach (var item in list)
        {
            if (predicate(item))
            {
                output(transform(item));
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("===== TASK 2.8 =====");

        MathOperation operation;

        operation = Calculator.Add;
        operation(10, 5);

        operation = Calculator.Subtract;
        operation(10, 5);

        operation = Calculator.Multiply;
        operation(10, 5);

        operation = Calculator.Divide;
        operation(10, 5);

        Console.WriteLine("\nMulticast Delegate:");

        MathOperation multi = Calculator.Add;
        multi += Calculator.Multiply;

        multi(4, 2);

        Console.WriteLine("\nFunc Delegate:");

        Func<double, double, double> funcAdd = (a, b) =>
        {
            double r = a + b;
            Console.WriteLine($"Func Add : {r}");
            return r;
        };

        funcAdd(10, 20);

        Console.WriteLine("\n===== TASK 2.9 =====");

        AlarmClock alarm = new AlarmClock();

        Person person = new Person();
        CoffeeMachine coffee = new CoffeeMachine();

        alarm.OnAlarmRing += person.WakeUp;
        alarm.OnAlarmRing += coffee.StartCoffee;

        alarm.RingAlarm();

        Console.WriteLine("\n===== TASK 2.10 =====");

        Action<string> printUpper = s =>
            Console.WriteLine(s.ToUpper());

        printUpper("bridge course");

        Func<int, int, int> multiply = (a, b) => a * b;

        Console.WriteLine($"Multiply : {multiply(6, 7)}");

        Predicate<int> isEven = n => n % 2 == 0;

        List<int> numbers = new List<int>()
        {
            1,2,3,4,5,6,7,8,9,10
        };

        Console.WriteLine("\nEven Numbers Squared:");

        Processor.ProcessList(
            numbers,
            isEven,
            x => x * x,
            x => Console.WriteLine(x)
        );
    }
}