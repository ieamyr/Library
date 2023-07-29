using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Book : Library
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public bool Borrowings { get; set; }
        public Book()
        {
        }
    }
}
