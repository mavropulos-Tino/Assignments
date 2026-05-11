using Task01___Searchable.Interfaces;
namespace Task01___Searchable.models;
public class Document : ISearchable
{
    public string Title { get; set; }
    public string Content { get; set; }

    public Document(string title, string content)
    {
        Title = title;
        Content = content;
    }

    public bool Search(string word)
    {
        return Content.Contains(word);
    }
}