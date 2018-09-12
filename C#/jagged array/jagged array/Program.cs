using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged_array
{
    class Program
    {  static circle [] circ=new circle [2];
    static square[] sq = new square[2];

        static void Main(string[] args)
    {
        sq[0] = new square();
        sq[0].L = 12;
        Console.WriteLine(sq[0].area());
        
            //jaagged array
        int[][] jag = new int[2][];
        jag[0] = new int[2];
        jag[1] = new int[2];
        for (int i = 0; i < jag.Length; i++)
        {
            for (int j = 0; j < jag.Length; j++)
            {
                jag[i][j] = int.Parse(Console.ReadLine());
            }
        }
        foreach (int[] j in jag)
        {
            foreach (int i in j)
            {
                jag[i+2][i] = int.Parse(Console.ReadLine());

            }
        }
            //int[][] jagged = new int[3][];
            //jagged[0] = new int[3];
            //jagged[1] = new int[2];
            //jagged[2] = new int[4];
            //foreach (int [] j in jagged )
            //{
            //    foreach (int  i  in j)
            //    {
            //        jagged[i][i] = int.Parse(Console.ReadLine());                  

            //    } 
            //}
            //for (int i = 0; i < jagged.Length; i++)
            //{
            //    for (int j = 0; j <jagged[i].Length; j++)
            //    {
            //        jagged[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}
            // array of objects
            circ[0] = new circle();
            circ[1] = new circle();
            circ[0].Rad= 12;
           Console.WriteLine(circ[0].rad=12);                     
           // Console.WriteLine(circ[0].Rad+12);
            Console.WriteLine(circ[0].per());
            Console.WriteLine(circ[1].area()); // it can't see circ[0]
               

        }
    }
}
