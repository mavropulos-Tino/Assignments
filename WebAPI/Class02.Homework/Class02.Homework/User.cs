namespace Class02.Homework;
public class User
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public int Age { get; set; }

    public User()
    {
    }

    public User(int id, string firstName, string lastName, string email, int age)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Age = age;
    }

}
