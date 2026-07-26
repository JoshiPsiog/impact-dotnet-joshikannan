using System.Reflection;
using Week03.PatternsLab.Attributes;
using Week03.PatternsLab.Models;

namespace Week03.PatternsLab.Demos;

public static class AttributeDemo
{
    public static void Run()
    {
        Console.WriteLine("\n========== TASK 3.12 ==========\n");

        User user = new();

        user.Name = "JoshikannanNeelanar";

        Type type = typeof(User);

        foreach (PropertyInfo property in type.GetProperties())
        {
            MaxLengthNoAttribute? attribute =
                property.GetCustomAttribute<MaxLengthNoAttribute>();

            if (attribute != null)
            {
                string value = property.GetValue(user)?.ToString() ?? "";

                if (value.Length > attribute.Length)
                {
                    Console.WriteLine(
                        $"Warning : {property.Name} exceeds {attribute.Length} characters.");
                }
            }
        }
    }
}