using System;

namespace compositionlabEC
{
    public class Book
    {
        private string isbn;
        private string title;
        private Author author;

        public Book()
        {
            //default constructor
        }
        public Book(string isbn, string title, Author author)
        {
            this.isbn = isbn;
            this.title = title;
            this.author = author;
        }

        public string GetIsbn()
        {
            return isbn;
        }
        public void SetIsbn(string isbn)
        {
            this.isbn = isbn;
        }
        public string GetTitle()
        {
            return title;
        }
        public void SetTitle(string title)
        {
            this.title = title;
        }
        public Author GetAuthor()
        {
            return author;
        }
        public void SetAuthor(Author author)
        {
            this.author = author;
        }

        public override string ToString()
        {
            return isbn + "  " + title + "  " + author.ToString();
        }

    }
}
