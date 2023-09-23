using System;
using System.Xml.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Article> articles = new List<Article>();
        int numberArticles = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberArticles; i++)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.TrimEntries).ToArray();
            string title = input[0];
            string content = input[1];
            string author = input[2];
            Article article = new Article(title, content, author);
            articles.Add(article);
        }
        foreach (Article article in articles)
        {
            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
        }
    }
}
class Article
{
    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }
}