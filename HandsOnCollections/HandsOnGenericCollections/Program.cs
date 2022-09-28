using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    class Sample
    {
        public int a;
        public string b;
    }
    class Demo<T>
    {
        public T a;
        public T b;
    }
    class Demo1<T,K>
    {
        public T a;
        public K b;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Sample s1 = new Sample();
            //s1.a = 10;
            //s1.b = "Hello";
            //Sample s2 = new Sample();
            //s2.a = 100;
            //s2.b = "Ram";
            //Demo<int> d1 = new Demo<int>();
            //d1.a = 10;
            //d1.b = 20;
            //Demo<string> d2 = new Demo<string>();
            //d2.a = "A";
            //d2.b = "AAA";
            //Demo1<int, string> d11 = new Demo1<int, string>();
            //d11.a = 10;
            //d11.b = "Ram";
            // list_demo.M();
            // list_demo1.M();
            // Dictionary_Demo.M();
            queue_demo.M();

        }
    }
}
