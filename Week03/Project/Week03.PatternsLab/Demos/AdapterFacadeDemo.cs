using Week03.PatternsLab.Services;

namespace Week03.PatternsLab.Demos;

public static class AdapterFacadeDemo
{
    public static void Run()
    {
        Console.WriteLine("\n========== TASK 3.9 ==========\n");

        Console.WriteLine("----- Adapter Pattern -----");

        XmlReportAdapter adapter = new();

        Console.WriteLine(adapter.GetXmlReport());

        Console.WriteLine();

        Console.WriteLine("----- Facade Pattern -----");

        OrderFacade facade = new();

        facade.PlaceOrder();
    }
}