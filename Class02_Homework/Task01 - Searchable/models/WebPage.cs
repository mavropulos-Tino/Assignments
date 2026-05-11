using System.Text.RegularExpressions;
using Task01___Searchable.Interfaces;
namespace Task01___Searchable.models;
public class WebPage : ISearchable
{
    public string Url { get; set; }
    public string Html { get; set; }

    public WebPage(string url, string html)
    {
        Url = url;
        Html = html;
    }

    public bool Search(string word)
    {
        string parsed = Regex.Replace(Html, "<.*?>", "");
        return parsed.Contains(word);
    }
}
