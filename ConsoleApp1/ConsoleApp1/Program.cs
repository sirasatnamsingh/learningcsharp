using System;

using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!!");

            //int number = Convert.ToInt32(Console.ReadLine());

            //int result = 1;
            //for (int i = 1; i <= number; i++)
            //{
            //    result = result * i;
            //}
            //Console.WriteLine(result);

            //List<int> a = new List<int>();
            //a.Add(1);
            //a.Add(5);
            //a.Add(6);
            //a.Add(3);
            //a.Add(10);

            //int total = 0;
            ////foreach (int item in a)
            ////{
            ////    total = total + item;
            ////}
            //for(int i = 0; i < a.Count; i++)
            //{
            //    total = total + a[i];
            //}

            //Console.WriteLine(total);

            // Find Even Numbers // 

            //int num = Convert.ToInt32(Console.ReadLine());
            //int total = 0;
            //for (int i = 1; i <= num; i++)
            //{

            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //        total = total + 1;
            //    }
            //}

            //Console.WriteLine("Total even numbers are " +total);

            // Formula to find fibonacci series //

            //int num = Convert.ToInt32(Console.ReadLine());

            //int first = 0;
            //int second = 1;
            //int next = 0;

            //Console.WriteLine(first);
            //Console.WriteLine(second);

            //for (int i = 2; i < num; i++)
            //{
            //    next = second + first;
            //    Console.WriteLine(next);
            //    first = second;
            //    second = next;
            //}


            //int num = Convert.ToInt32(Console.ReadLine());

            //int first = 0;
            //int second = 1;
            //int next = 0;

            //Console.WriteLine(first);
            //Console.WriteLine(second);

            //for (int i = 2; i < num; i ++ ) 

            //{
            //    next = second + first;
            //    Console.WriteLine(next);
            //    first = second;
            //    second = next;
            //}
            // Test
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; ++i)

            {
                int mul = num * i;
                Console.WriteLine(num + " X " + i + " = " + mul);

            }
            Console.ReadLine();
        }
    }
}
