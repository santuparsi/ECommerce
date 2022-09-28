using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    class list_demo1
    {
        class Student
        {
            public int sid;
            public string sname;
        }
        public static void M()
        {
            List<char> l1 = new List<char>() { 'a', 'e', '1', 'r' }; //collection initializer
            List<string> l2 = new List<string>()
            {
                "Rohan",
                "Karan",
                "Jeson",
                "Suren"
            };
            Student s1 = new Student() { sid = 1, sname = "Rohan" };
            Student s2 = new Student() { sid = 2, sname = "Karan" };
            Student s3 = new Student() { sid = 3, sname = "Charan" };
            Student s4 = new Student() { sid = 4, sname = "Suren" };
            Student s5 = new Student() { sid = 5, sname = "David" };
            Student s6 = new Student() { sid = 6, sname = "Sachin" };
            List<Student> list = new List<Student>() { s1, s2, s3, s4, s5, s6 };
            foreach(Student s in list)
            {
                Console.WriteLine("Id:{0} Name:{1}", s.sid, s.sname);
            }
        }
    }
}
