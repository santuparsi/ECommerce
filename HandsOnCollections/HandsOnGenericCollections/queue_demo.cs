using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    internal class queue_demo
    {
        public static void M()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Rose");
            queue.Enqueue("Lilly");
            queue.Enqueue("Jasmine");
            queue.Enqueue("Tulips");
            Console.WriteLine("Peek Value: " + queue.Peek());
            Console.WriteLine("Pop Value: " + queue.Dequeue());
        }
    }
}
