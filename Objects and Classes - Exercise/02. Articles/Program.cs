using System;
using System.Reflection.Metadata;

namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] myArticle = Console.ReadLine()
                .Split(", ");

            string articleTitle = myArticle[0];
            string articleContent = myArticle[1];
            string articleAuthor = myArticle[2];

            Article article = new Article(articleTitle, articleContent, articleAuthor);

            int numberCommands = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberCommands; i++)
            {
                string[] commandArgs = Console.ReadLine().Split(": ");

                string commandType = commandArgs[0];
                string commandChange = commandArgs[1];

                if (commandType == "Edit")
                {
                    article.Edit(article, commandChange);
                }
                else if (commandType == "ChangeAuthor")
                {
                    article.ChangeAuthor(article, commandChange);
                }
                else if (commandType == "Rename")
                {
                    article.Rename(article, commandChange);
                }
            }

            article.ToString(article);
        }
    }

    public class Article
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

        public void ToString(Article article)
        {
            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
        }
    }
}
