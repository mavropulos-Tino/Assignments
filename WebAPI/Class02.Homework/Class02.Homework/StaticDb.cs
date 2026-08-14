namespace Class02.Homework;
public static class StaticDb
{
    public static List<User> Users = new()
    {
        new User(1, "Arthur", "Pendelton", "arthur.pendelton@gmail.com", 21),
        new User(2, "Clara", "Halloway", "clara.halloway@gmail.com", 24),
        new User(3, "Julian", "Vance", "julian.vance@gmail.com", 18),
        new User(4, "Naomi", "Brooks", "naomi.brooks@gmail.com", 29),
        new User(5, "Silas", "Thorne", "silas.thorne@gmail.com", 19),
        new User(6, "Beatrice", "Finch", "beatrice.finch@gmail.com", 25),
        new User(7, "Marcus", "Sterling", "marcus.sterling@gmail.com", 30),
        new User(8, "Daphne", "Miller", "daphne.miller@gmail.com", 23)
    };
}