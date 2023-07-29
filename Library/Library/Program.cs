using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            //=============== Add Book ==
            Book book = new Book();
            book.Name = "Midnight Library";
            book.Author = "Matt Haig";
            book.AddBook(book);
            //=============== Add Member ==
            Member member = new Member();
            member.FName = "Ali";
            member.AddMember(member);
            //=============== Search Book ==
        }
    }
}
