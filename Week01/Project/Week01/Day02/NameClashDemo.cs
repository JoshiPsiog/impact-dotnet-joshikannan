namespace Week01.Day02
{
    public static class NameClashDemo
    {
        public static void Run()
        {
            Console.WriteLine("=== Task 1.6 : Namespace Name Clash ===");

            // Both Helper classes have the same name.
            // Using the fully qualified name removes the ambiguity.

            ModuleA.Helper.Greet();
            ModuleB.Helper.Greet();
        }
    }
}