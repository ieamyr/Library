using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Library
{
    class Library
    {
        List<Book> Books;
        List<Member> Members;

        public Library()
        {
            Books = new List<Book>();
            Members = new List<Member>();
        }

        public void AddBook(Book book)
        {
            Console.WriteLine("Book Add successfully.");
        }
        public void DisplayBooks()
        {
        }
        public void SearchBook(string title)
        {
            Console.WriteLine("Book : ");
        }
        public void AddMember(Member member)
        {
            Console.WriteLine("Member Add successfully.");
        }
        public void BorrowBook(Member member, Book book)
        {
            if (book != null)
            {
                Console.WriteLine("Book borrowed successfully.");
            }
            else
            {
                Console.WriteLine("Book is not available for borrowing.");
            }
        }
        public void ReturnBook(Member member, Book book)
        {
        }
    }
}
