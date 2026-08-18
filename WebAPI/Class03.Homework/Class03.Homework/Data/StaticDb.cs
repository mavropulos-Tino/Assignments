using Class03.Homework.Models;

namespace Class03.Homework.Data;
public static class StaticDb
{
    public static List<Book> Books { get; set; } = new List<Book>()
    {
        new Book() { Author = "Jane Austen", Title = "Pride and Prejudice" },
        new Book() { Author = "George Orwell", Title = "1984" },
        new Book() { Author = "Herman Melville", Title = "Moby-Dick" },
        new Book() { Author = "F. Scott Fitzgerald", Title = "The Great Gatsby" },
        new Book() { Author = "Leo Tolstoy", Title = "War and Peace" },
        new Book() { Author = "Harper Lee", Title = "To Kill a Mockingbird" },
        new Book() { Author = "Charlotte Brontë", Title = "Jane Eyre" },
        new Book() { Author = "Homer", Title = "The Odyssey" },
        new Book() { Author = "Fyodor Dostoevsky", Title = "Crime and Punishment" },
        new Book() { Author = "Ernest Hemingway", Title = "The Old Man and the Sea" }
    };
}
