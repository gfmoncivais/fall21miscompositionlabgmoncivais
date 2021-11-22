using System;

namespace compositionlabEC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Composition Lab

            // Task 3- Create an Author
            Author myAuthor = new Author("Jeff Lucas", 'm', "jslucas@cba.ua.edu");
            Console.WriteLine(myAuthor.ToString());

            // Task 4- Create a Book
            Book myBook = new Book("12243", " My Book, Your Book", myAuthor);
            Console.WriteLine(myBook.ToString());

            // Task 5 - Access the Author
            Console.WriteLine(myBook.GetAuthor().ToString());

            // Task 6 - Anonymous Object
            Book yourBook = new Book("4321", "The Phantom Book", new Author("Jamie", 'f', "jamie@mail.com"));
            Console.WriteLine(yourBook.ToString());

            // Task 7 - Anonymous Object
            yourBook.GetAuthor().SetEmail("jamie@crimson.ua.edu");
            Console.WriteLine(yourBook.ToString());
        }
    }
}
