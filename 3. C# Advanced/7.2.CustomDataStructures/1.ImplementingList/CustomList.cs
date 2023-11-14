using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _01.ImplementingList
{
    public class CustomList
    {
        private const int Capacity = 2;
        private int[] items;
        public CustomList()
        {
            items = new int[Capacity];
        }
        public int Count { get; private set; }
        public int this[int index]
        {
            get
            {
                CheckIfIndexIsValid(index);
                return items[index];
            }
            set
            {
                CheckIfIndexIsValid(index);
                items[index] = value;
            }
        }
        public void Add(int value)
        {
            if (Count == items.Length)
            {
                Resize();
            }
            items[Count++] = value;
        }
        public int RemoveAt(int index)
        {
            CheckIfIndexIsValid(index);
            var removedItem = items[index];
            items[index] = default(int);
            ShiftLeft(index);
            Count--;
            if (Count <= items.Length / 4)
            {
                Shrink();
            }
            return removedItem;
        }
        public void InsertAt(int index, int value)
        {
            CheckIfIndexIsValid(index);
            if (Count == items.Length)
            {
                Resize();
            }
            ShiftRight(index);
            items[index] = value;
            Count++;
        }
        public bool Contains(int value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (items[i] == value)
                {
                    return true;
                }
            }
            return false;
        }
        public void Swap(int firstIndex, int secondIndex)
        {
            CheckIfIndexIsValid(firstIndex);
            CheckIfIndexIsValid(secondIndex);
            var temp = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = temp;
        }
        private void Resize()
        {
            var copy = new int[items.Length * 2];
            for (int i = 0; i < Count; i++)
            {
                copy[i] = items[i];
            }
            items = copy;
        }
        private void Shrink()
        {
            var copy = new int[items.Length / 2];
            for (int i = 0; i < Count; i++)
            {
                copy[i] = items[i];
            }
            items = copy;
        }

        private void ShiftLeft(int index)
        {
            for (int i = index; i < items.Length - 1; i++)
            {
                items[i] = items[i + 1];
            }
        }
        private void ShiftRight(int index)
        {
            for (int i = Count - 1; i > index; i--)
            {
                items[i] = items[i - 1];
            }
        }
        private void CheckIfIndexIsValid(int index)
        {
            if (index >= Count || index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
