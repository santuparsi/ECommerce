using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnNonGenericCollection
{
    class Student
    {
        public int sid;
        public string sname;
    }
    class Test_Student
    {
        ArrayList ar;
        public Test_Student()
        {
            Student s1 = new Student() { sid = 1, sname = "Rohan" };
            Student s2 = new Student() { sid = 2, sname = "Karan" };
            Student s3 = new Student() { sid = 3, sname = "Charan" };
            Student s4 = new Student() { sid = 4, sname = "Suren" };
            Student s5 = new Student() { sid = 5, sname = "David" };
            Student s6 = new Student() { sid = 6, sname = "Sachin" };
           ar = new ArrayList();
            ar.Add(s1);
            ar.Add(s2);
            ar.Add(s3);
            ar.Add(s4);
            ar.Add(s5);
            ar.Add(s6);
        }
        public Student Search(int sid)
        {
            try
            {

                foreach (Student s in ar)
                {
                   if(s.sid==sid)
                    {
                        return s;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                //Handling exceptio
                throw ex;
            }
        }
        public static void M5()
        {
            
            //adding student objects to arraylist
            try
            {
                Test_Student obj = new Test_Student();
                Student s = obj.Search(3);
                if (s != null)
                {
                    Console.WriteLine("Name: " + s.sname);
                }
                else
                    Console.WriteLine("Invalid Student ID");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
            
        }
    }
}
