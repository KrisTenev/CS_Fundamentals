using System;
using System.Linq;

namespace _2._Articles
{
    internal class Program
    {
        static void Main()
        {

            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string title = input[0];
            string content = input[1];
            string author = input[2];

            Article book = new Article(title, content, author);

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] command = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Edit")
                {
                    book.EditContent(command[1]);
                }
                if (command[0] == "ChangeAuthor")
                {
                    book.ChangeAuthor(command[1]);
                }
                if (command[0] == "Rename")
                {
                    book.RenameTitle(command[1]);
                }
            }

            Console.WriteLine(book);
        }
        public class Article
        {
            //constructor
            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }

            //properties
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            //methods
            public void EditContent(string newContent)
            {
                this.Content = newContent;
            }

            public void ChangeAuthor(string newAuthor)
            {
                this.Author = newAuthor;
            }

            public void RenameTitle(string newTitle)
            {
                this.Title = newTitle;
            }

            //override
            public override string ToString()
            {
                return $"{this.Title} - {this.Content}: {this.Author}";
            }
        }
    }
}
