using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ");
                Student student = new Student();

                string firstName = tokens[0];
                student.FirstName = firstName;
                student.LastName = tokens[1];
                student.Grade = double.Parse(tokens[2]);

                students.Add(student);

            }
            students = students.OrderByDescending(s => s.Grade).ToList();

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
            }
        }

        class Student
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public double Grade { get; set; }
        }
    }
}
