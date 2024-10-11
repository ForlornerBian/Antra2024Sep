namespace ExerciseGenerics;

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Usage of MyStack<T>
        Console.WriteLine("===== MyStack<T> Usage =====");
        MyStack<int> stack = new MyStack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        Console.WriteLine($"Popped element: {stack.Pop()}"); // Output: 3
        Console.WriteLine($"Stack count: {stack.Count()}");  // Output: 2

        // Usage of MyList<T>
        Console.WriteLine("\n===== MyList<T> Usage =====");
        MyList<string> myList = new MyList<string>();
        myList.Add("Hello");
        myList.Add("World");
        Console.WriteLine($"Contains 'Hello': {myList.Contains("Hello")}"); // Output: True
        Console.WriteLine($"Element at index 1: {myList.Find(1)}"); // Output: World
        myList.InsertAt("C#", 1);
        Console.WriteLine($"Element at index 1 after insertion: {myList.Find(1)}"); // Output: C#
        myList.DeleteAt(1);
        Console.WriteLine($"Element at index 1 after deletion: {myList.Find(1)}"); // Output: World

        // Usage of GenericRepository<T>
        Console.WriteLine("\n===== GenericRepository<T> Usage =====");
        GenericRepository<Student> studentRepository = new GenericRepository<Student>();

        // Add new students
        Student student1 = new Student { Id = 1, Name = "John Doe" };
        Student student2 = new Student { Id = 2, Name = "Jane Smith" };
        studentRepository.Add(student1);
        studentRepository.Add(student2);

        // Get all students
        IEnumerable<Student> students = studentRepository.GetAll();
        foreach (var student in students)
        {
            Console.WriteLine($"Student: {student.Name}");
        }

        // Find student by ID
        Student foundStudent = studentRepository.GetById(1);
        Console.WriteLine($"Found Student: {foundStudent.Name}");

        // Remove student
        studentRepository.Remove(student1);
        studentRepository.Save();
    }
}