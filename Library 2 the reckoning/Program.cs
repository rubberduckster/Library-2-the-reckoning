using Library_2_the_reckoning;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Book instances
            Book twilight = new Book("Twilight", "Stephenie Meyer", "978-0-316-16017-9", 2005);
            Book beautifulCreatures = new Book("Beautiful Creatures", "Kami Garcia & Margaret Stohl");
            Book theMazeRunner = new Book("The Maze Runner", "James Dashner", "978-0-385-73794-4", 2009);
            Book theRing = new Book("The Ring", "Koji Suzuki", "978-1932234411", 1991);
            Book theHungerGames = new Book("The Hunger Games", "Suzanne Collins", "978-0439023481", 2008);

            theHungerGames.CheckOut(); // Marking "The Hunger Games" as on loan
            beautifulCreatures.CheckOut(); // Marking "Beautiful Creatures" as on loan

            List<Book> books = new List<Book>
            {
                twilight,
                beautifulCreatures,
                theMazeRunner,
                theRing,
                theHungerGames
            };

            Library library = new Library(books);

            Console.WriteLine("Welcome to the Library!");
            Console.WriteLine("Type 1: Loan book");
            Console.WriteLine("Type 2: Return book");
            Console.Write("Input: ");

            string userInput = Console.ReadLine();

            switch (userInput) 
            {
                case "1":
                    library.ShowBooks();
                    Console.WriteLine("Enter ISBN to loan a book");
                    Console.Write("Input: ");
                    string isbnToLoan = Console.ReadLine();
                    library.LoanBook(isbnToLoan);
                    break;

                case "2":
                    library.ShowBooks();
                    Console.WriteLine("Enter ISBN to return a book");
                    Console.Write("Input: ");
                    string isbnToReturn = Console.ReadLine();
                    library.ReturnBook(isbnToReturn);
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
