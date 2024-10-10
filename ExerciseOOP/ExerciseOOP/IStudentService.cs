namespace ExerciseOOP;

public interface IStudentService : IPersonService
{
    void EnrollInCourse(Course course);
    double CalculateGPA();
}