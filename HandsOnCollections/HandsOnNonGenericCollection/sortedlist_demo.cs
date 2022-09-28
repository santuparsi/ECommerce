using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnNonGenericCollection
{
    class sortedlist_demo
    {
        public static void M3()
        {
            SortedList obj = new SortedList();
            obj.Add(1020, "Rohan");
            obj.Add(1012, "Charan");
            obj.Add(1017, "Monica");
            obj.Add(1001, "Rajan");
            obj.Add(1025, "Sachin");
            string s = Convert.ToString(obj[1025]);
            foreach (int k in obj.Keys)
            {
                Console.WriteLine("Id:{0} Name:{1}", k, obj[k]);
            }
            foreach (DictionaryEntry d in obj)
            {
                Console.WriteLine("ID:{0} Name:{1}", d.Key, d.Value);
            }
        }
    }
}
