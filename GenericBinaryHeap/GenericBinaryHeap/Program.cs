using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBinaryHeap
{
    class Program
    {
        static void Main(string[] args)
        {
            MaxBinaryHeap<int> maxHeap = new MaxBinaryHeap<int>();
            maxHeap.Insert(15);
            maxHeap.Insert(2);
            maxHeap.Insert(22);
            maxHeap.Insert(27);
            maxHeap.Insert(11);
            maxHeap.Insert(44);
            maxHeap.Insert(16);
            maxHeap.Insert(3);
            maxHeap.Insert(58);
            Console.WriteLine(maxHeap.HeapSize);
            Console.WriteLine();
            Console.WriteLine(maxHeap.Extract() + "   " + maxHeap.HeapSize);
            
            //Console.WriteLine();
            //MinBinaryHeap<int> minHeap = new MinBinaryHeap<int>();
            //minHeap.Insert(0);
            //minHeap.Insert(1);
            //minHeap.Insert(22);
            //minHeap.Insert(13);
            //minHeap.Insert(10);
            //minHeap.Insert(31);
            //minHeap.Insert(15);
            //minHeap.Insert(3);
            //minHeap.outHeap();

        }
    }
}
