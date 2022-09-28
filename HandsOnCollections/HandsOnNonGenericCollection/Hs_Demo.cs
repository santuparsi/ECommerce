using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnNonGenericCollection
{
    class Hs_Demo
    {
        public static void M1()
        {
            Hashtable hs = new Hashtable();
            //adding key-value pairs.
            hs.Add(1000, "Rohan");
            hs.Add(1020, "Karan");
            hs.Add(1230, "John");
            hs.Add("2222", "Sachin");
            hs.Add(1111, "Rajan");
            string name = hs[1020].ToString(); //Tostring() converts object into string
            hs.Remove(1111); //remove key-value pair
            foreach(var k in hs.Keys)
            {
                Console.WriteLine("Id:{0} Name:{1}", k, hs[k]);
            }
            foreach(DictionaryEntry d in hs)
            {
                Console.WriteLine("Key:{0} Value:{1}", d.Key, d.Value);
            }
        }
    }
}
