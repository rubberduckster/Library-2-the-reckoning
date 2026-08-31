using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_2_the_reckoning
{
    class Library
    {
        private List<Book> books;
        private List<Borrower> borrowers;

        public Library(List<Book> books)
        {
            this.books = books;
        }

        public void LoanBook(string isbnInput)
        {
            foreach (Book book in books)
            {
                if (book.Isbn == isbnInput)
                {
                    try
                    {
                        book.CheckOut();
                        Console.WriteLine($"Book '{book.Title}' checked out successfully.");
                    }
                    catch (InvalidOperationException exception)
                    {
                        Console.WriteLine($"Error: {exception.Message}");
                    }
                }
             }
         }

        public void ReturnBook(string isbn)
        {
            foreach (Book book in books)
            {
                if (book.Isbn == isbn)
                {
                    if (book.IsOnLoan)
                    {
                        book.Return();
                        Console.WriteLine($"{book.Title} is returned.");
                    }
                    else
                    {
                        Console.WriteLine($"{book.Title} isn't on loan.");
                    }

                    return;
                }
            }

            Console.WriteLine("Der findes ingen bog med det ISBN.");
        }

        public void ShowBooks()
        {
            Console.WriteLine("Books in the library:");
            foreach (Book book in books)
            {
                string loanStatus;

                if (book.IsOnLoan)
                {
                    loanStatus = "On loan";
                }
                else
                {
                    loanStatus = "Available";
                }

                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.Isbn}, Status: {loanStatus}");
            }
        }
    }
}
