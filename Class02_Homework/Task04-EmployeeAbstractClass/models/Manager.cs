using Task04_EmployeeAbstractClass.models;
public class Manager : Employee
{
    public decimal BaseSalary { get; set; }
    public decimal Bonus { get; set; }

    public Manager(int id, string name, decimal baseSalary, decimal bonus) : base(id, name)
    {
        BaseSalary = baseSalary;
        Bonus = bonus;
    }

    public override decimal CalculateSalary()
    {
        return BaseSalary + Bonus;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Salary: ${CalculateSalary()}");
    }
}