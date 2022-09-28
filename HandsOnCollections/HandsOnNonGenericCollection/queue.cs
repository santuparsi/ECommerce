using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnNonGenericCollection
{
    class queue
    {
        public static void M2()
        {
            Queue obj = new Queue();
            //add items to the queue
            obj.Enqueue("Rohan");
            obj.Enqueue("Karan");
            obj.Enqueue("Jeson");
            obj.Enqueue("Suren");
            obj.Enqueue("John");
            foreach (string s in obj)
                Console.WriteLine(s);
            Console.WriteLine("Peek value: " + obj.Peek()); //return Rohan
            Console.WriteLine("Delete value: " + obj.Dequeue()); //remove 1st item
            Console.WriteLine();
            foreach (string s in obj)
                Console.WriteLine(s);
            obj.Enqueue("Rohan");
            Console.WriteLine();
            foreach (string s in obj)
                Console.WriteLine(s);
            Console.ReadKey();

        }
    }
}
