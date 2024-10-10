namespace ExerciseOOP;

public class Course
{
    public string Name { get; set; }
    public List<Student> EnrolledStudents { get; set; } = new List<Student>();

    public Course(string name)
    {
        Name = name;
    }

    public void EnrollStudent(Student student)
    {
        EnrolledStudents.Add(student);
    }
}
