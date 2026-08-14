namespace Task04_EmployeeAbstractClass.models;
public class Programmer : Employee
{
    public decimal HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    public Programmer(int id, string name, decimal hourlyRate, int hoursWorked) : base(id, name)
    {
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;
    }

    public override decimal CalculateSalary()
    {
        return HourlyRate * HoursWorked;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Salary: ${CalculateSalary()}");
    }
}