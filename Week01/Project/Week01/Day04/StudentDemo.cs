namespace Week01.Day04;

public static class StudentDemo
{
    public static void Run()
    {
        Console.WriteLine("===== Constructor Chaining =====");

        Student student = new Student("Joshi", 24);

        Console.WriteLine($"Name : {student.Name}");
        Console.WriteLine($"Age  : {student.Age}");

        Console.WriteLine();

        Console.WriteLine("===== Validation =====");

        student.Age = 150;

        Console.WriteLine();

        Console.WriteLine("===== Method Overloading =====");

        Console.WriteLine(student.CalculateGrade(80));

        Console.WriteLine($"{student.CalculateGrade(500, 420)} %");

        Console.WriteLine();

        Console.WriteLine("===== const vs readonly =====");

        Console.WriteLine($"College : {Student.College}");

        Console.WriteLine($"Admission Date : {student.AdmissionDate}");

        // Student.College = "XYZ"; // ❌ Compile Error

        // student.AdmissionDate = DateTime.Now; // ❌ Compile Error

        // Explanation:
        // const cannot be changed anywhere.
        // readonly can only be assigned in the constructor.
    }
}