using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList
    {
        private class Node
        {
            public int Value { get; set; }
            public Node NextNode { get; set; }
            public Node PreviousNode { get; set; }
            public Node(int value)
            {
                Value = value;
            }
        }
        private Node head;
        private Node tail;
        public int Count { get; private set; }

        public void AddFirst(int element)
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
        public void AddLast(int element)
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
        public int RemoveFirst()
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
        public int RemoveLast()
        {
            if(Count == 0)
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
        public void ForEach(Action<int> action)
        {
            var currentNode = head;
            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }
        public int[] ToArray()
        {
            var array = new int[Count];
            var index = 0;
            var currentNode = head;
            while (currentNode != null)
            {
                array[index++] = currentNode.Value;
                currentNode = currentNode.NextNode;
            }
            return array;
        }
    }
}
