using System;
using System.Threading;

namespace Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            Console.WriteLine(start);
            Console.WriteLine("Hello World!");
            function1();
            function2();
            DateTime end1 = DateTime.Now;
            Console.WriteLine(end1);
            Console.WriteLine("After threding");
            Thread obj1 = new Thread(function1);
            Thread obj2 = new Thread(function2);
            obj1.Start();
            obj2.Start();
            DateTime end2 = DateTime.Now;
            Console.WriteLine(end2);




        }
        public static void function1()
        {
            for (int i = 0; i <10 ; i++)
            {
                Console.WriteLine("function1 running : "+ i);
                Thread.Sleep(2000);
            }
        }
        public static void function2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("function2 running : " + i);
                Thread.Sleep(2000);

            }
        }
    }
}
