using Task01.models;
namespace Task01;
internal class Program
{
    static void Main(string[] args)
    {
        User query1 = UserDatabase.SearchById(1);
        Console.WriteLine($"User with that ID is: {query1.Name}");

        User query2 = UserDatabase.SearchByName("User3");
        Console.WriteLine($"User with that Name is {query2.Age} old with ID of {query2.Id}");

        User query3 = UserDatabase.SearchByAge(22);
        Console.WriteLine($"User with that Age is: {query3.Name}");
    }
}

/*
Create class User that will have 3 properties Id, Name, Age.
Create static class UserDatabase that will contain a list of Users (create couple of users and add them to the list).
Create method (or methods) Search() that will search the UserDatabase by Id, Name and Age and will return users as a result.
*/