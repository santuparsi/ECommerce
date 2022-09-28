using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    internal class list_demo
    {
        public static void M()
        {
            List<int> l1 = new List<int>();
            l1.Add(12);
            l1.Add(23);
            l1.Add(34);
            l1.Add(45);
            int i = l1[2];
            foreach (int k in l1)
            {
                Console.WriteLine(k);
            }

        }
    }
}
