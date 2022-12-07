using System;

namespace _05._HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string articleTitle = Console.ReadLine();
            string articleContent = Console.ReadLine();

            int count = 1;
            string articleComment = string.Empty;
            while((articleComment = Console.ReadLine()) != "end of comments")
            {
                if(count == 1)
                {
                    Console.WriteLine("<h1>");
                    Console.WriteLine($"    {articleTitle}");
                    Console.WriteLine($"</h1>");
                    Console.WriteLine("<article>");
                    Console.WriteLine($"    {articleContent}");
                    Console.WriteLine($"</article>");
                    count = 0;
                }

                Console.WriteLine("<div>");
                Console.WriteLine($"    {articleComment}");
                Console.WriteLine($"</div>");
            }
        }
    }
}
