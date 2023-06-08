using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Articles_2._0
{
    internal class Program
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 1; i <= n; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string title = input[0];
                string content = input[1];
                string author = input[2];

                articles.Add(new Article(title, content, author));
            }

            string orderBy = Console.ReadLine();

            if (orderBy == "title")
            {
                articles = articles.OrderBy(x => x.Title).ToList();
            }
            else if (orderBy == "content")
            {
                articles = articles.OrderBy(x => x.Content).ToList();
            }
            else if (orderBy == "author")
            {
                articles = articles.OrderBy(x => x.Author).ToList();
            }                      

            //    articles.Sort(delegate (Article x, Article y)
            //    {
            //        if (orderBy == "title")
            //        {
            //            return x.Title.CompareTo(y.Title);
            //        }                   
            //        else if (orderBy == "content")
            //        {
            //            return x.Content.CompareTo(y.Content);
            //        }
            //        else
            //        {
            //            return x.Author.CompareTo(y.Author);
            //        }
            //    });

            foreach (Article article in articles)
            {
                Console.WriteLine(article);
            }
        }
    }

    public class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
