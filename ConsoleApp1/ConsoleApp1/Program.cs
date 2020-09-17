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

            // Find Odd Number 

            //Console.WriteLine("Please enter any number to find the odd numbers ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //// int Ans = 0;

            //for (int i = 1; i <= num; i++)
            //{

            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //        //Ans = Ans + 1;
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

            // Multiplication - Tables 

            //int num = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= 10; ++i)
            //{
            //    int mul = num * i;
            //    Console.WriteLine(num + " X " + i + " = " + mul);
            //}

            // Find Percentage 

            //Console.WriteLine("Please enter the value");
            //int value = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please enter the Percentage");
            //double per = Convert.ToDouble(Console.ReadLine());

            //double ans = value * per / 100F;
            //Console.WriteLine( per+ "%" + " Percentage of " + value + " is "+ ans + "." );


            // FInd Compound Insterest (Monthly Basis)

            //Console.WriteLine("Please the amount to invest per month: ");
            //double amount = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Please enter the expected rate of on investment : ");
            //double rate = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Please enter number of months for investment : ");
            //double b = Convert.ToDouble(Console.ReadLine());

            //double maturity = 0;


            //for (int i = 1; i <= b; i++)

            //{
            //    double rateofinterest = rate / b * 100;
            //    double interest = ((maturity + amount) * rate) / 100;
            //    maturity = maturity + amount + interest;
            //}

            //Console.WriteLine("Invested amount is " + (amount * b));
            //Console.WriteLine("Maturity amount is " + (maturity));

            Console.WriteLine("Please enter the 1st number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the 2nd number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the 3rd number: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the 4th number: ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the 5th number: ");
            int e = Convert.ToInt32(Console.ReadLine());

            List<int> data = new List<int>();
            data.Add(a);
            data.Add(b);
            data.Add(c);
            data.Add(d);
            data.Add(e);

            int i = a;
            for (int index = 1; index < data.Count(); index++)
            {
                if (i > data[index])
                { i = data[index]; }
            }

            Console.WriteLine("The samllest value is " + i +  ".");
            Console.ReadLine();
        }
    }
}
