using System;

namespace NEWDELEGATE
{     public  delegate int delegatee (int a,int b); 
    class calc
    {
      public int sum  (int a,int b)
        { return a + b; }
      public int sub(int a, int b)
      { return a - b; } 

    }

}
