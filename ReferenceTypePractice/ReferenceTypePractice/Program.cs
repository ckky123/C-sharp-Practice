using System;
using System.Data;

namespace ReferenceTypePractice
{
    class Program
    {
        static void Main(string[] args)
        {

            GradeBook g1 = new GradeBook();
            GradeBook g2 = new GradeBook();

            DateTime date = new DateTime();
            string s = "";

            g2 = g1;
            g1.Name = "Wendy's book";

            
            g1 = new GradeBook();
            g1 = g2;
            g2.Name = "Chris' book";

            int a = 150;

            int b = 10;

            Console.WriteLine(Object.ReferenceEquals(a.GetType(), b.GetType()));


            Console.WriteLine(date);

            Console.WriteLine("date: " + date);

            Console.WriteLine( a+ "string");

            Console.WriteLine("string " + a);

            var abc =  b + a + 15+ "abc";

            Console.WriteLine(Object.ReferenceEquals(a.GetType(), abc.GetType()));
            Console.WriteLine(abc.GetType());
            Console.WriteLine(a.GetType());

            Console.WriteLine("g2.Name: "+ g2.Name);
            Console.WriteLine("g1.Name: " + g1.Name);

            Console.ReadKey();
        }


        static void WriteResult(string description, float restult) {





        }

    }
}
