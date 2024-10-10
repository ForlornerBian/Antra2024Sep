namespace ExerciseOOP;

public abstract class Person : IPersonService
{
    private List<string> _addresses = new List<string>();
    private DateTime _dateOfBirth;
    private decimal _salary;

    public Person(DateTime dateOfBirth, decimal salary)
    {
        _dateOfBirth = dateOfBirth;
        Salary = salary;
    }

    public decimal Salary
    {
        get => _salary;
        set
        {
            if (value < 0)
                throw new ArgumentException("Salary cannot be negative.");
            _salary = value;
        }
    }

    public int CalculateAge()
    {
        return DateTime.Now.Year - _dateOfBirth.Year;
    }

    public void AddAddress(string address)
    {
        _addresses.Add(address);
    }

    public string GetAddresses()
    {
        return string.Join(", ", _addresses);
    }

    public abstract decimal CalculateSalary(); // Polymorphism: to be overridden by derived classes
}
