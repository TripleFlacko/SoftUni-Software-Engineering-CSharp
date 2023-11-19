using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        public List<T> Items { get; set; }
        public int Index { get; set; }
        public int Count { get; set; }

        public ListyIterator(List<T> items)
        {
            Items = items;
            Index = 0;
            Count = items.Count;
        }
        public bool Move()
        {
            if (Index + 1 < Count)
            {
                Index++;
                return true;
            }
            return false;
        }
        public bool HasNext()
        {
            return Index < Count - 1;
        }
        public void Print()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(Items[Index]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in Items)
            {
                yield return item;
            }

        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
