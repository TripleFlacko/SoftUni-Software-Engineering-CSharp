using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _03.ImplementingQueue
{
    public class CustomQueue
    {
        private const int Capacity = 4;
        private const int FirstElementIndex = 0;
        private int[] items;
        private int count;
        public CustomQueue()
        {
            count = 0;
            items = new int[Capacity];
        }
        public int Count => count;

        public void Enqueue(int item)
        {
            if (count == items.Length)
            {
                Resize();
            }
            items[count++] = item;
        }
        public int Dequeue()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            var dequeuedItem = items[FirstElementIndex];
            items[FirstElementIndex] = default(int);
            count--;
            for (int i = 0; i < count; i++)
            {
                items[i] = items[i + 1];
            }
            items[Count] = default(int);
            if (Count <= items.Length / 4)
            {
                Shrink();
            }
            return dequeuedItem;
        }
        public int Peek()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            var peekedItem = items[FirstElementIndex];
            return peekedItem;
        }
        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < count; i++)
            {
                action(items[i]);
            }
        }

        private void Shrink()
        {
            var copy = new int[items.Length / 2];
            for (int i = 0; i < count; i++)
            {
                copy[i] = items[i];
            }
            items = copy;
        }
        private void Resize()
        {
            var copy = new int[items.Length * 2];
            for (int i = 0; i < count; i++)
            {
                copy[i] = items[i];
            }
            items = copy;
        }
    }
}
