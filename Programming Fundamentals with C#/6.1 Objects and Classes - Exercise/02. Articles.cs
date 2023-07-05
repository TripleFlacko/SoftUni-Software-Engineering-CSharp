using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(", ").ToArray();
        string title = input[0];
        string content = input[1];
        string author = input[2];
        Article article = new Article(title, content, author);

        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            string[] commands = Console.ReadLine().Split(':', StringSplitOptions.TrimEntries).ToArray();
            switch (commands[0])
            {
                case "Edit":
                    article.Edit(article, commands[1]);
                    break;

                case "ChangeAuthor":
                    article.ChangeAuthor(article, commands[1]);
                    break;

                case "Rename":
                    article.Rename(article, commands[1]);
                    break;
            }
        }
        Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
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

    public void Edit(Article article, string newContent)
    {
        article.Content = newContent;
    }
    public void ChangeAuthor(Article article, string newAuthor)
    {
        article.Author = newAuthor;
    }
    public void Rename(Article article, string newTitle)
    {
        article.Title = newTitle;
    }
}