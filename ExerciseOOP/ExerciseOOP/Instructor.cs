namespace ExerciseOOP;

public class Instructor : Person, IInstructorService
{
    private Department _department;
    private DateTime _joinDate;

    public Instructor(DateTime dateOfBirth, decimal salary, DateTime joinDate, Department department)
        : base(dateOfBirth, salary)
    {
        _joinDate = joinDate;
        _department = department;
    }

    public int Experience => DateTime.Now.Year - _joinDate.Year;

    public Department GetDepartment()
    {
        return _department;
    }

    public bool IsHeadOfDepartment()
    {
        return _department.Head == this;
    }

    public override decimal CalculateSalary()
    {
        // Base salary plus bonus for experience
        return Salary + (Experience * 100); 
    }
}
