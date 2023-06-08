using System;
using System.Collections.Generic;
using System.Text;

namespace _2._Articles
{
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
