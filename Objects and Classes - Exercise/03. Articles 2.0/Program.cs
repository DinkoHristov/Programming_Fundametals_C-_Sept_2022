using System;
using System.Collections.Generic;

namespace _03._Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCommands = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 1; i <= numberCommands; i++)
            {
                string[] myArticle = Console.ReadLine()
                .Split(", ");

                string articleTitle = myArticle[0];
                string articleContent = myArticle[1];
                string articleAuthor = myArticle[2];

                Article article = new Article(articleTitle, articleContent, articleAuthor);
                articles.Add(article);
            }

            string command = Console.ReadLine();

            if (command == "title" || command == "content" || command == "author")
            {
                foreach(Article article in articles)
                {
                    article.ToString(article);
                }
            }
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

        public void ToString(Article article)
        {
            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
        }
    }
}
