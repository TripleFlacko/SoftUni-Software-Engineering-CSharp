﻿using IteratorsAndComparators;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private SortedSet<Book> books;
        private IComparer<Book> comparer = new BookComparator();

        public Library(params Book[] books)
        {
            Books = new SortedSet<Book>(books, comparer);
        }
        public SortedSet<Book> Books
        {
            get { return books; }
            set { books = value; }
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(books);
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private class LibraryIterator : IEnumerator<Book>
        {
            private int index;
            private readonly List<Book> books;

            public LibraryIterator(IEnumerable<Book> books)
            {
                this.books = books.ToList();
                Reset();
            }

            public Book Current => books[index];

            object IEnumerator.Current => Current;

            public void Dispose(){}

            public bool MoveNext() => ++index < books.Count;

            public void Reset() => index = -1;
        }
    }
}
