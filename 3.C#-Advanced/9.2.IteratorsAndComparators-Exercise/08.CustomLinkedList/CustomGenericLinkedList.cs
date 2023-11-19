using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CustomLinkedList
{
    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        private class Node
        {
            public T Value { get; set; }
            public Node NextNode { get; set; }
            public Node PreviousNode { get; set; }
            public Node(T value)
            {
                Value = value;
            }
        }
        private Node head;
        private Node tail;
        public int Count { get; private set; }

        public void AddFirst(T element)
        {
            if (Count == 0)
            {
                head = tail = new Node(element);
            }
            else
            {
                var newHead = new Node(element);
                newHead.NextNode = head;
                head.PreviousNode = newHead;
                head = newHead;
            }
            Count++;

        }
        public void AddLast(T element)
        {
            if (Count == 0)
            {
                head = tail = new Node(element);
            }
            else
            {
                var newTail = new Node(element);
                newTail.PreviousNode = tail;
                tail.NextNode = newTail;
                tail = newTail;
            }
            Count++;
        }
        public T RemoveFirst()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }

            var firstElement = head.Value;
            head = head.NextNode;
            if (head != null)
            {
                head.PreviousNode = null;
            }
            else
            {
                tail = null;
            }
            Count--;
            return firstElement;
        }
        public T RemoveLast()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            var lastElement = tail.Value;
            tail = tail.PreviousNode;
            if (tail != null)
            {
                tail.NextNode = null;
            }
            else
            {
                head = null;
            }
            Count--;
            return lastElement;
        }
        public void ForEach(Action<T> action)
        {
            var currentNode = head;
            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }
        public T[] ToArray()
        {
            var array = new T[Count];
            var index = 0;
            var currentNode = head;
            while (currentNode != null)
            {
                array[index++] = currentNode.Value;
                currentNode = currentNode.NextNode;
            }
            return array;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currentNode = head;
            while (currentNode != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
