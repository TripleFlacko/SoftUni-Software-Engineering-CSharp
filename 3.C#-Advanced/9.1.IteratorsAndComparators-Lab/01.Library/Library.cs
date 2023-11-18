using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Library
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            Books = new List<Book>(books);
        }
        public List<Book> Books
        {
            get { return books; }
            set { books = value; }
        }
    }
}
