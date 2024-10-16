using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList<T> : IList<T>
    {
        public Node<T> Head { get; }
        public Node<T> Last { get; }
        public T this[int index]
        {
            get
            {
                return GetNodeByIndex(index)
            }
            set
            {
                GetNodeByIndex(index) = value
            }
        }

        public int Count { get; }

        public bool IsReadOnly { get; }

        private Node<T> GetNodeByIndex(int index)
        {
            if (index < Count && index > 0)
            {
                int placement = 0;
                Node<T> currentNode = Head;
                while (placement!=index)
                {
                    currentNode = currentNode.Next
                }
                return currentNode;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        
        private int GetLength()
        {
            if(Head==null)
            {
                return 0;
            }
            
            int countNodes = 1;
            Node<T> currentNode = Head;
            
            while (currentNode.Next!=null)
            {
                currentNode = currentNode.Next;
                countNodes++;
            }
            
            return countNodes;
        }
        
        public void Add(T item)
        {
            try
            {
                Last.Next = item as Node<T>;
                Last = item as Node<T>;
            }
            catch (Exception ItemOfWrongeTypeException)
            {
                ItemOfWrongeTypeException.Message;
            }
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
