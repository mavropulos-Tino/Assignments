using Task04_EmployeeAbstractClass.models;

namespace Class02_Homework;
class Program
{
    static void Main(string[] args)
    {
        Employee[] employees = new Employee[]
        {
            new Manager(1, "Alice", 3000, 520),
            new Programmer(2, "Bob", 13, 150)
        };

        foreach (var employee in employees)
        {
            employee.DisplayInfo();
            Console.WriteLine();
        }
    }
}