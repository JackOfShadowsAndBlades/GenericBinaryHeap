using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBinaryHeap
{
    class MaxBinaryHeap<T> : BinaryHeap<T> where T : IComparable
    {
        public MaxBinaryHeap() : base() { }

        public override void Insert(T value)
        {
            base.Insert(value);
            int i = HeapSize - 1;
            int parent = (i - 1) / 2;
            while (i > 0 && parent >= 0)
            {
                if (Heap[parent].CompareTo(Heap[i]) < 0)
                {
                    T temp = Heap[i];
                    Heap[i] = Heap[parent];
                    Heap[parent] = temp;
                }
                i = parent;
                parent = (i - 1) / 2;
            }
        }

        public void outHeap()
        {
            int i = 0;
            int k = 1;
            while (i < HeapSize)
            {
                while ((i < k) && (i < HeapSize))
                {
                    Console.Write(Heap[i] + " ");
                    i++;
                }
                Console.WriteLine();
                k = k * 2 + 1;
            }
        }

        void heapify(int i)
        {
            int left, right;
            T temp;
            left = 2 * i + 1;
            right = 2 * i + 2;
            if (left < HeapSize && Heap[i].CompareTo(Heap[left]) < 0)
            {
                temp = Heap[i];
                Heap[i] = Heap[left];
                Heap[left] = temp;
                heapify(left);
            }
            if (right < HeapSize && Heap[i].CompareTo(Heap[right]) < 0)
            {
                temp = Heap[i];
                Heap[i] = Heap[right];
                Heap[right] = temp;
                heapify(right);
            }
        }

        public T Extract()
        {
            T max;
            max = Heap[0];
            Heap[0] = Heap[HeapSize - 1];
            Heap.RemoveAt(HeapSize - 1);
            heapify(0);
            return max;
        }
    }
}
