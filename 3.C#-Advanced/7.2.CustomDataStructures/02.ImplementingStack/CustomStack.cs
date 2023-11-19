using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _02.ImplementingStack
{
    public class CustomStack
    {

        private int[] items;
        private const int capacity = 4;
        private int count;

        public int Count => count;

        public CustomStack()
        {
            items = new int[capacity];
        }


        public void Push(int item)
        {
            if (count == items.Length)
            {
                Resize();
            }
            items[count++] = item;
        }

        public int Pop()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            var poppedItem = items[count - 1];
            items[count - 1] = default(int);
            count--;

            if (Count <= items.Length / 4)
            {
                Shrink();
            }

            return poppedItem;
        }

        public int Peek()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return items[count - 1];
        }

        public void ForEach(Action<int> action)
        {
            for (int i = count - 1; i >= 0; i--)
            {
                action(items[i]);
            }
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
        private void Shrink()
        {
            var copy = new int[items.Length / 2];
            for (int i = 0; i < count; i++)
            {
                copy[i] = items[i];
            }
            items = copy;
        }
    }
}
