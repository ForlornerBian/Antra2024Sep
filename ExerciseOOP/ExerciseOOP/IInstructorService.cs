namespace ExerciseOOP;

public interface IInstructorService : IPersonService
{
    Department GetDepartment();
    bool IsHeadOfDepartment();
}