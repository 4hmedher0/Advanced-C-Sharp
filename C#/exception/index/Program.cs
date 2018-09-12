using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 9, b=0;
            ////int.Parse(Console.ReadLine());
            //try { int div = a / b; }
            //catch (FormatException)
            //{
               
            //        b = int.Parse(Console.ReadLine());
            //    Console.WriteLine(a / b);
            //    Console.ReadKey();
            //}
            //catch (DivideByZeroException)
            //{
            //    while (b == 0)
            //        b = int.Parse(Console.ReadLine());
            //    Console.WriteLine(a / b);
            //    Console.ReadKey();
            //}
            ////    catch (FormatException)
            ////{ 
            ////    a = int.Parse(Console.ReadLine());

            ////    b= int.Parse(Console.ReadLine());
            ////Console.WriteLine("wrong");
            ////}
            //finally { Console.WriteLine("div by zero is not expected value "); }
            int[] arr = { 1, 2, 3 };
            try
            {
                Console.WriteLine(arr[4]);

            }

            catch (IndexOutOfRangeException){ Console.WriteLine("is out of range "); }
            //finally { Console.WriteLine("the matrix is 0 to 3 "); }   
            int num = 10,num2=0;
            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            { Console.WriteLine("the decimal is from 0 to 9 ");
            }
            try { int div = num / num2; }
            catch (DivideByZeroException)
            {
                while (num2 == 0)
                    num2 = int.Parse(Console.ReadLine());
                Console.WriteLine(num / num2);
            }
            finally { Console.WriteLine("by a smart user "); }
        }
    }
}
