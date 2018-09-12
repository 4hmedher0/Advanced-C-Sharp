using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] arr = new int[,] { { 00, 3, 5 }, { 3, 4, 9999 } };
            //foreach (int i in arr)
            //{
            //    Console.WriteLine("{0}", i);

            //}
            //int[,] arr2 = new int[,] { { 2, 5, 7 }, { 3, 6, 8 }, { 11, 21, 8888 } };
            //foreach (int i in arr2)
            //{
            //    Console.WriteLine("{0}", i);
            //}
            //Array arr = arr2;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("LENGTH");
            //}
            //for (int i = 0; i < arr2.Rank; i++)
            //{
            //    Console.WriteLine("Rank");
            //}
            //int[, ,] ED = { { { 2, 3, 5 }, { 3, 5, 6 }, { 0, 9, 8 }, { 2, 3, 5 } } };
            //Console.WriteLine("*********    " + ED.Rank);

            //int[, ,] arr3 = new int[,,] { { { 4, 5, 7 }, { 5, 8, 9 }, { 9, 7, 0 }, { 33, 21, 99 }, { 99, 88, 77 } } };
            //foreach (int i in arr3) { Console.WriteLine("{0}", i); }
            //Console.WriteLine("++++++++++" + arr3.Length + "    " + arr3.Rank + " " + arr3.GetLength(1));
            //copy array
            int[,]ma1=new int [,]{{2,3,7},{9,2,8}};
            int[,] copma1=new int[ma1.GetLength(0),ma1.GetLength(1)];
            //for (int i = 0; i < ma1.Length; i++)
            //{
            // copma1[i]=ma1[i];
            //}
            //copma1[1] = 8; Console.WriteLine(copma1[1]);
            //ma1.CopyTo(copma1,0);
            //Array.Copy(ma1, copma1, 2);
            //ma1.CopyTo(copma1, 0);
          // Array.Copy(ma1, copma1,6); //copy 2d array .
            //copma1 = ma1.Clone() as int[,]; //anthor method to copy 
            //copma1 = (int[,])ma1.Clone();

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine(copma1[i, j]);
            //    }
            //}
            Random r = new Random();
            Console.WriteLine( r.Next(2000));
            Console.WriteLine(r.Next(2, 8));


           



            //ANONYMOUS OBJECT 
           // var section = new[] { 
           // new {studentname ="ali",grade =20},     
           // new {studentname ="medo",grade =30},                                           
           // new {studentname ="beto",grade =50}
           // };
           // foreach (var student in section)
           // {
           //     Console.WriteLine("studnet: {0} grade : {1}", student.studentname, student.grade);
           // }
           // Console.WriteLine('\n');
           // var Shop = new[] {
           // new {sort ="screen",brand ="hp",price =700},
           // new {sort ="screen",brand ="Lenovo",price=500},
           // new {sort ="Computer",brand ="Dell",price=1000},            
            
           // };
           // foreach (var shop in Shop)
           // { Console.WriteLine("sort: {0:d8} &    Brand: {1}    & price {2:d5} eg", shop.sort, shop.brand, shop.price); };
           // Console.WriteLine();
           // var familiy = new[] {
           // new {member="mostafa",data=1969},
           // new {member= "ebarahim", data=1998},
           // new {member="ahmed",data=1999},
           // new {member="hagar",data=2004},
           // new {member="salma",data=2009}
                       
           //};
           // foreach (var item in familiy)
           // {
           //     Console.WriteLine(" member: {0:d10}  data:{1:d8} ", item.member, item.data);
           // }



        }

    }
    }

