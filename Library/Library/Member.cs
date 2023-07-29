using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library
{
     class Member : Library
    { 
        public String FName { get; set; }
        public List<Book> Book { get; set; }  
        public Member()
        {
        }
    }

}
