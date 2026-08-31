using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_2_the_reckoning
{
    class Borrower
    {
        private string name;
        private int borrowerNumber;
        // private int numberOfBooksLoaned; // Removed this field from the assignement as it can be derived from the borrowedBooks list
        private List<Book> borrowedBooks; // Added this upon class discussion of adding it

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }

                name = value;
            }
        }

        public int BorrowerNumber
        {
            get
            {
                return borrowerNumber;
            }
        }

        public int NumberOfBooksLoaned
        {
            get
            {
                return borrowedBooks.Count;
            }
        }

        public Borrower(string name, int borrowerNumber)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be empty.");
            }

            this.name = name;
            this.borrowerNumber = borrowerNumber;

            borrowedBooks = new List<Book>();
        }

        public void BorrowBook(Book book)
        {
            borrowedBooks.Add(book);
        }

        public void ReturnBook(Book book)
        {
            if (borrowedBooks.Contains(book))
            {
                borrowedBooks.Remove(book);
            }
            else
            {
                throw new InvalidOperationException("This book is not borrowed.");
            }
        }
    }
}
