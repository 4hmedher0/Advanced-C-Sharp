using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = {{ 1, 10, 12 },{-4,3,77}}; 

            for (int i = 0; i < 2; i++)
            {
                int temp = arr[0, 0];
                for (int j = 0; j < 2; j++)
                {


                    if (arr[i,j] >= temp)
                        temp = arr[i,j];
                    arr[i, j] = temp;
                    // arr[0] = arr[i];

                }
            }
  
//  Console.WriteLine(arr[0,0]+"\n"+arr[0,1]+"\n"+arr[1,0]+"\n"+arr[1,1]);
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <=2; j++)
                {
                    Console.WriteLine(arr[i,j]);   
                }
            }
        }
    }
}
