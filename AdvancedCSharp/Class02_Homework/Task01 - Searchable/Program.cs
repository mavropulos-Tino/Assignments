using Task01___Searchable.models;
namespace Class02_Homework;
class Program
{
    static void Main(string[] args)
    {
        Document document = new Document("Hello guys", "Hello guys welcome to the document");
        Console.WriteLine(document.Search("welcome"));
        Console.WriteLine(document.Search("triangle"));

        WebPage webPage = new WebPage("https://google.com", "<p>Google Search Engine</p>");
        Console.WriteLine(webPage.Search("Search"));
        Console.WriteLine(webPage.Search("cube"));
    }
}