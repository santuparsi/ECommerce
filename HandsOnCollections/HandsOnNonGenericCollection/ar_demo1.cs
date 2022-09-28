using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnNonGenericCollection
{
    class ar_demo1
    {
        static void M2()
        {
            ArrayList ar = new ArrayList();
            ar.Add("Harish");
            ar.Add(23);
            ar.Add(67.4);
            ar.Add(true);
            ar.Add(new DateTime(1990, 12, 12));
            foreach (object o in ar)
                Console.WriteLine(o);
        }
    }
}
