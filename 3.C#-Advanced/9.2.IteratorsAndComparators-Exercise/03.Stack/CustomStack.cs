using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Stack
{
    public class CustomStack<T> :IEnumerable<T>
    {
		private T[] items;
		private int capacity = 2;
		private int count = 0;
        public int Count => count;

        public CustomStack()
        {
            items = new T[capacity];
        }

		public void Push(T item)
		{
			if (count == items.Length)
			{
				Resize();
			}
			items[count++] = item;
		}
		public T Pop()
		{
            if (count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

			var poppedItem = items[count - 1];
			items[count - 1] = default(T);
			count--;

            if (count <= items.Length / 4)
            {
                Shrink();
            }

			return poppedItem;
        }
		public T Peek()
		{
            if (count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return items[count - 1];
		}

        private void Resize()
        {
			var copy = new T[capacity * 2];
			for (int i = 0; i < items.Length; i++)
			{
				copy[i] = items[i];
			}
			items = copy;
        }
		private void Shrink()
		{
			var copy = new T[capacity / 2];
            for (int i = 0; i < count; i++)
            {
                copy[i] = items[i];
            }
            items = copy;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = count - 1; i >= 0; i--)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
