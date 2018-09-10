using System;
using NEWDELEGATE;
  public delegate int dele (int a,int b );
  class programme
  {
      public static void Main()
      {
          //dele b = new dele(ali);
          dele w = new dele(medo);
//          Console.WriteLine(w(2, 3));
          calc d = new calc();
          delegatee del;
          del = d.sum;
          Console.WriteLine( del(10, 20));
          del = d.sub;
          Console.WriteLine( del(20, 10));

          
      }

      public static void ali(int a, int b)
      {
          Console.WriteLine("{0} and {1})",a,b);

      }
      public static int medo(int x, int y)
      {

          return x * y;
      }  
  }