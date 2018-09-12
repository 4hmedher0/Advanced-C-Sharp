using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rev
{
    class Program
    {
        static yourclass[] b = new yourclass[3];
        static myclass[] a = new myclass[3]; // array of objects لازم يتعرف خارج المين ويتعرف بقي جوة عنصر عنصر
        static void Main(string[] args)
        {
            a[1] = new myclass();
             b[1] = new yourclass();
           //  a[1].n1 = 10;
            //Console.WriteLine(a[1].n1);
            b[1].N = 90;
            Console.WriteLine( b[1].N);
            a[1].n2 = 21;
            Console.WriteLine(a[1].n2+"_");
            //Console.Write("we are hrere ");
            //yourclass o = new yourclass();
            //myclass p = new myclass(); // we implmet destructor 
            // jaggged array  
            //int [][] array =new int [][]{new int []{2,3},new int []{4,5,6},new int []{9,7,8,0}};
            //for (int i = 0; i <array.Length; i++)
            //{
            //    int[] innerarray = array[i];
            //    Console.WriteLine("array number :"+i);
            //    for (int j = 0; j <innerarray.Length; j++)
            //    {
            //        Console.WriteLine(innerarray[i]);
            //    }
            //    Console.WriteLine();
            //}
            //ـــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــ

            // property 
            //myclass m = new myclass();
            //m.Num =12;
            //Console.WriteLine(m.Num);
            //m.Num = 29; Console.WriteLine(m.Num);
            //m.Name = "ali"; Console.WriteLine(m.Name);
            //m.Name = "medo"; Console.WriteLine(m.Name);
            //ـــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــ
            // copy array 
            //int []mat =new int  [] {2,8,6};
            //int[] mat2 = (int[])mat.Clone();
            //Console.WriteLine(mat2[2]);
            // int []mat3=new int [3];
            //mat.CopyTo(mat3,0); // (arryname , first index 
            //Console.WriteLine(mat[1]);
            //int [] mat4=new int [3];
            //Array.Copy(mat, mat4, 3); // source array, copy array , Length 
            //Console.WriteLine(mat4[0]);
            //ـــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــ
            // array   of objects 
             //  static myclass [] a=new myclass [3]; //  لازم يكون ستاتك وخارج المين  مش هنا 
            //a[2] = new myclass(); //  لازم يتعرف هما كاوبجكت بقي 
            //a[2].method();
            //b[1] = new yourclass();
            //b[1].method();
          //ـــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــ   
           // exception 
            //int a = 2, b = 0;
            //try { int q = a / b; }
            ////throw new DivideByZeroException {Console.WriteLine("bad job ");} //  i hope to know about throw
            //catch (DivideByZeroException) { Console.WriteLine("enter vaild vluae "); }
            //finally { Console.WriteLine("plz b smart "); }   
            //ـــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــ
            Random r = new Random();
            Console.WriteLine(r.Next(1, 20));
           //ـــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــ
            //anoymous  objects 
            var v = new[] {
          
            new  {name="medo",id =1},
            new  {name= "ali",id=2}        
         
            };
            foreach (var i in v )
            {
                Console.WriteLine(i.id+","+i.name);
            }
  
        }
    }
}
