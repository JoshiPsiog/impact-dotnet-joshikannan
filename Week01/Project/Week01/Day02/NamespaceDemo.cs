using SchoolManagement;

namespace Week01.Day02
{
    public static class NamespaceDemo
    {
        public static void Run()
        {
            Console.WriteLine("=== Task 1.5 : Namespaces ===");

            // Without using directive (Fully Qualified Name)
            Console.WriteLine("\nWithout using directive:");
            SchoolManagement.Student student1 = new SchoolManagement.Student();
            student1.Display();

            // With using directive
            Console.WriteLine("\nWith using directive:");
            Student student2 = new Student();
            student2.Display();

            /*
             Difference:
             - Without using: Use the fully qualified name (SchoolManagement.Student).
             - With using: Import the namespace once and use the class name directly.
            */
        }
    }
}