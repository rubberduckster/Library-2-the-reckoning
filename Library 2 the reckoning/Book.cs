using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_2_the_reckoning
{
    class Book
    {
        // Private fields
        private string title;
        private string author;
        private string isbn;
        private int publicationYear;
        private bool isOnLoan;
        private Borrower currentBorrower;

        // Public read-only properties
        public string Title
        {
            get
            {
                return title;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }
        }

        public string Isbn
        {
            get
            {
                return isbn;
            }
        }

        public bool IsOnLoan
        {
            get
            {
                return isOnLoan;
            }
        }

        // Public constructors
        public Book(string title, string author)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("Title cannot be empty.");
            }

            if (string.IsNullOrWhiteSpace(author))
            {
                throw new ArgumentException("Author cannot be empty.");
            }

            this.title = title;
            this.author = author;
            isbn = "Unknown";
            publicationYear = 0;
            isOnLoan = false;
        }

        public Book(string title, string author, string isbn, int publicationYear)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("Title cannot be empty.");
            }

            if (string.IsNullOrWhiteSpace(author))
            {
                throw new ArgumentException("Author cannot be empty.");
            }

            this.title = title;
            this.author = author;
            this.isbn = isbn;
            this.publicationYear = publicationYear;
            isOnLoan = false;
        }

        // Public methods
        public void CheckOut()
        {
            if (isOnLoan)
            {
                throw new InvalidOperationException("The book is already on loan.");
            }
            else
            {
                isOnLoan = true;
            }
        }

        public void Return()
        {
            isOnLoan = false;
        }
    }
}
