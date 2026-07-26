using System.Reflection;
using Week03.PatternsLab.Reflection;

namespace Week03.PatternsLab.Demos;

public static class ReflectionDemo
{
    public static void Run()
    {
        Console.WriteLine("\n========== TASK 3.11 ==========\n");

        Type type = typeof(Invoice);

        Console.WriteLine($"Class : {type.Name}");

        Console.WriteLine("\nProperties");

        foreach (PropertyInfo property in type.GetProperties())
        {
            Console.WriteLine($"{property.Name} : {property.PropertyType.Name}");
        }

        Console.WriteLine("\nMethods");

        foreach (MethodInfo method in type.GetMethods())
        {
            Console.WriteLine(method.Name);
        }

        Console.WriteLine("\nConstructors");

        foreach (ConstructorInfo constructor in type.GetConstructors())
        {
            Console.WriteLine(constructor);
        }

        Console.WriteLine("\nActivator");

        object? invoice = Activator.CreateInstance(type);

        PropertyInfo? propertyInfo = type.GetProperty("Customer");

        propertyInfo?.SetValue(invoice, "Joshikannan");

        Console.WriteLine(propertyInfo?.GetValue(invoice));
    }
}