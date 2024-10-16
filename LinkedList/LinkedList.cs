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
                Last = Last.Next;
            }
            catch (WrongTypeException ex)
            {
                throw new WrongTypeException("Item needs to be a Node.");
            }
        }

        public void Clear()
        {
            Head = null;
            Last = null;
        }

        public bool Contains(T item)
        {
            try
            {
                Node<T> searchedNode = item as Node<T>;
                Node<T> currentNode = Head;
                while (currentNode.Next!=null)
                {
                    if (currentNode == searchedNode)
                    {
                        return true;
                    }
                    currentNode = currentNode.Next;
                }
                return currentNode == searchedNode;
            }
            catch (WrongTypeException  ex)
            {
                throw new WrongTypeException("Item needs to be a Node.");
            }
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
           if(arrayIndex<array.Length && arrayIndex>-1)
            {
                Array.Resize(ref array, array.Length+Count);
                T[] leftovers = new T[Count];
                int currentIndex = arrayIndex;
                Node<T> currentNode = Head;
                for (int i= 0; i<leftovers.Length; i++)
                {
                    leftovers[i] = array[currentIndex];
                    array[currentIndex] = currentNode.Value;
                    currentNode = currentNode.Next;
                    currentIndex ++;
                }
                for (int i=currentIndex; i<array.Length; i++)
                {
                    if(array[i]==null)
                    {
                        for(int j=0; j<leftovers.Length; j++)
                        {
                            array[i] = leftovers[j];
                            i++;
                        }
                        break;
                    }
                }
            }
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
