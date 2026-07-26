namespace Week01.Day02
{
    public static class IdentifierDemo
    {
        public static void Run()
        {
            Console.WriteLine("=== Task 1.7 : Identifiers ===");

            // Local variables follow camelCase naming convention.
            int studentAge = 20;
            string studentName = "Joshi";
            double averageMark = 89.5;
            bool isActive = true;
            char grade = 'A';

            Console.WriteLine($"Student Age   : {studentAge}");
            Console.WriteLine($"Student Name  : {studentName}");
            Console.WriteLine($"Average Mark  : {averageMark}");
            Console.WriteLine($"Is Active     : {isActive}");
            Console.WriteLine($"Grade         : {grade}");

            Console.WriteLine();

            // 'class' is a reserved keyword.
            // Prefixing it with '@' allows it to be used as an identifier.

            string @class = "C#";

            Console.WriteLine($"Keyword Identifier : {@class}");


        }
    }
}