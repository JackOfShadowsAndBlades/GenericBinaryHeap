using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBinaryHeap
{
    abstract class BinaryHeap<T> where T: IComparable
    {
        public List<T> Heap;

        public BinaryHeap()
        {
            Heap = new List<T>();
        }

        public int HeapSize
        {
            get { return Heap.Count(); }
        }

        public virtual void Insert(T value)
        {
            Heap.Add(value);
        }

        public virtual T Extract()
        {
            T value = Heap[0];
            Heap[0] = Heap[HeapSize - 1];
            Heap.RemoveAt(HeapSize - 1);
            return value;
        }
    }
}
