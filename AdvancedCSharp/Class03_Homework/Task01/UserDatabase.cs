using Task01.models;
namespace Task01;
public static class UserDatabase
{
    public static List<User> users = new List<User>
    {
        new User(1, "User1", 28),
        new User(2, "User2", 21),
        new User(3, "User3", 22),
        new User(4, "User4", 28),
        new User(5, "User5", 19)
    };

    public static User SearchById(int id)
    {
        return users.FirstOrDefault(user => user.Id == id);
    }

    public static User SearchByName(string name)
    {
        return users.FirstOrDefault(user => user.Name == name);
    }

    public static User SearchByAge(int age)
    {
        return users.FirstOrDefault(user => user.Age == age);
    }
}
