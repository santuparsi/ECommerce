using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnNonGenericCollection
{
    class stack_demo
    {
        public static void M4()
        {
            Stack obj = new Stack();
            obj.Push(10);
            obj.Push(12);
            obj.Push(23);
            obj.Push(45);
            obj.Push(90);
            foreach (int k in obj)
                Console.WriteLine(k);
            Console.WriteLine("Peek value: " + obj.Peek()); //return top value
            Console.WriteLine("Pop value: " + obj.Pop());// remove top value
            Console.WriteLine();
            foreach (int k in obj)
                Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
