﻿namespace Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
               string[] tokens = Console.ReadLine().Split(", ");
                string title = tokens[0];
                string content = tokens[1];
                string author = tokens[2];

                articles.Add(new Article(title, content, author));
            }
            string criteria = Console.ReadLine();
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
        public string Author { get; set;}

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}