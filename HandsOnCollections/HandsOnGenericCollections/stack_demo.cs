using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    class stack_demo
    {
        public static void M()
        {
            Stack<int> s1 = new Stack<int>();
            s1.Push(10);
            s1.Push(20);
            Stack<string> s2 = new Stack<string>();
            s2.Push("Rohan");
            s2.Push("Karan");
        }
    }
}
