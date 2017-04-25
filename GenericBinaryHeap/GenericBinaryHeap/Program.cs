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
            maxHeap.Insert(0);
            maxHeap.Insert(1);
            maxHeap.Insert(22);
            maxHeap.Insert(13);
            maxHeap.Insert(10);
            maxHeap.Insert(31);
            maxHeap.Insert(15);
            maxHeap.Insert(3);
            maxHeap.outHeap();
            Console.WriteLine(maxHeap.Extract());
            maxHeap.outHeap();
        }
    }
}
