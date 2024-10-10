namespace ExerciseOOP;

public class Student : Person, IStudentService
{
    private Dictionary<Course, char> _grades = new Dictionary<Course, char>();

    public Student(DateTime dateOfBirth) : base(dateOfBirth, 0) { }

    public void EnrollInCourse(Course course)
    {
        _grades.Add(course, 'F'); // Default grade is 'F'
    }

    public override decimal CalculateSalary()
    {
        return 0; // Students don't have a salary
    }

    public double CalculateGPA()
    {
        // Basic GPA calculation based on grades
        int totalPoints = 0;
        foreach (var grade in _grades.Values)
        {
            totalPoints += GetGradePoints(grade);
        }
        return totalPoints / (double)_grades.Count;
    }

    private int GetGradePoints(char grade)
    {
        switch (grade)
        {
            case 'A': return 4;
            case 'B': return 3;
            case 'C': return 2;
            case 'D': return 1;
            case 'F': return 0;
            default: return 0;
        }
    }
}
