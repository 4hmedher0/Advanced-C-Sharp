using System;
namespace badjaggedarray
{
    class Program
    {
        static void Main(string[] args)
        {
             int [][] f=new  int [][]{new int[] {2,3},new int[] {8,9,13,77,0},new int [] {9,99,88}};
             for (int i = 0; i < f.Length; i++)
             {
                 int[] inn = f[i];//  بتباصي اول مصفوفة لل إن وتبقي كدة المصفوفةإن معاها اول مصفوفة تاني   
                 Console.WriteLine("inmber of array :"+i);
                 for (int j = 0; j <inn.Length; j++) // بيمر علي المصفوفة  إن اللي انت بتباصي ليها المصفوفات اللي في المصفوفة الكبيرة 
                 {
                     Console.WriteLine(inn[j]);
                 }
                 Console.WriteLine();
             }
        }
    }
}
