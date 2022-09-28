using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnNonGenericCollection
{
    class Program
    {
        static void M()
        {
            //arraylist demo
            ArrayList ar = new ArrayList();
            //adding items to arraylist
            ar.Add(12); //0
            ar.Add(23); //1
            ar.Add(34); //2
            ar.Add(45);
            ar.Add(56);
            int k = (int)ar[2]; //access value from arraylist using index
            foreach (int i in ar)
                Console.WriteLine(i);
            ar.Insert(3, 90);
            ar.Sort();//sort arraylist elements
                      // ar.Reverse();//revere arraylist elements
            ar.Remove(34); //remove value from collection
            foreach (int i in ar)
                Console.WriteLine(i);
            if (ar.BinarySearch(12) >= 0)
                Console.WriteLine("Valid value..");
            else
                Console.WriteLine("Invalid value..");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {

            //M();
            //Test_Student.M5();
            //Hs_Demo.M1();
            //sortedlist_demo.M3();
            // stack_demo.M4();
            queue.M2();
            Console.ReadKey();
        }
    }
}
