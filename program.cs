using System;
using System.Collections.Generic;

namespace StudentRegistration
{
    class Program
    {
        // Class to store student info
        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Course { get; set; }
        }

        static List<Student> students = new List<Student>();
        static int studentCounter = 1;

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n=== Student Registration System ===");
                Console.WriteLine("1. Register a new student");
                Console.WriteLine("2. View all students");
                Console.WriteLine("3. Exit");
                Console.Write("Select an option: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        RegisterStudent();
                        break;
                    case "2":
                        ViewStudents();
                        break;
                    case "3":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }

            Console.WriteLine("Exiting the program...");
        }

        static void RegisterStudent()
        {
            Console.Write("\nEnter student name: ");
            string name = Console.ReadLine();

            Console.Write("Enter course: ");
            string course = Console.ReadLine();

            Student newStudent = new Student
            {
                Id = studentCounter++,
                Name = name,
                Course = course
            };

            students.Add(newStudent);

            Console.WriteLine($"Student {newStudent.Name} registered successfully with ID {newStudent.Id}.");
        }

        static void ViewStudents()
        {
            Console.WriteLine("\n--- Registered Students ---");

            if (students.Count == 0)
            {
                Console.WriteLine("No students registered yet.");
                return;
            }

            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Course: {student.Course}");
            }
        }
    }
}
