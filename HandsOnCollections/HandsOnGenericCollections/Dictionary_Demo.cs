using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    class Dictionary_Demo
    {
        public static void M()
        {
            //Dictionary<int, string> obj = new Dictionary<int, string>();
            SortedList<int, string> obj = new SortedList<int, string>();
            obj.Add(1000, "Rohan");
            obj.Add(1020, "Karan");
            obj.Add(1012, "Mohan");
            obj.Add(1089, "Suren");
            obj.Add(1078, "Roshan");
            string n = obj[1020]; //if key is invalid in returns null
            foreach(KeyValuePair<int,string> k in obj)
            {
                Console.WriteLine("Id:{0} Name:{1}", k.Key, k.Value);
            }
            Console.ReadKey();
        }
    }
}
