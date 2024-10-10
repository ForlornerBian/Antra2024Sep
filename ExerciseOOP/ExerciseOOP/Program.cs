namespace ExerciseOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call the ArrayReversal methods
            Console.WriteLine("Question 1: Array Reversal:");
            int[] numbers = ArrayReversal.GenerateNumbers(10);  // Generate an array of length 10
            ArrayReversal.Reverse(numbers);                     // Reverse the array
            ArrayReversal.PrintNumbers(numbers);                // Print the reversed array

            // Call the FibonacciSequence methods
            Console.WriteLine("\nQuestion 2: Fibonacci Sequence:");
            FibonacciSequence.PrintFirstNFibonacci(10);         // Print the first 10 Fibonacci numbers
            
            // Testing Instructor, Student, Course, Department
            Console.WriteLine("\nOOP Question 1: Person / Instructor / Student / Course / Department");
            Department csDept = new Department("Computer Science", null, 50000, DateTime.Now.AddYears(-1), DateTime.Now.AddYears(1));
            Instructor instructor = new Instructor(new DateTime(1980, 5, 15), 60000, new DateTime(2005, 9, 1), csDept);
            csDept.Head = instructor;

            Student student = new Student(new DateTime(2000, 1, 1));
            Course course = new Course("Programming 101");
            student.EnrollInCourse(course);
            course.EnrollStudent(student);

            Console.WriteLine($"Instructor Age: {instructor.CalculateAge()}");
            Console.WriteLine($"Instructor Salary: {instructor.CalculateSalary()}");
            Console.WriteLine($"Student GPA: {student.CalculateGPA()}");

            // Testing Color and Ball
            Console.WriteLine("\nOOP Question 2: Color / Ball");
            Color redColor = new Color(255, 0, 0);
            Ball redBall = new Ball(10, redColor);
            redBall.Throw();
            redBall.Throw();
            Console.WriteLine($"Red Ball Throw Count: {redBall.GetThrowCount()}");

            redBall.Pop();
            redBall.Throw();
            Console.WriteLine($"Red Ball Throw Count After Pop: {redBall.GetThrowCount()}");
        }
    }
}