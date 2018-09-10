using System;
using thirdele;
class prog
{ 

    
    
    static void Main ()
    {
        // {
     dele d = new dele();
//   //  delegat q = new delegat("medo", 20); // must take a method 
//     delegat w;
     //d.citizen("medo", 23);
//     w = d.citizen;
//     d.person("aya", 88);
//     w = d.person; Console.WriteLine("_______________________________________\n\n");
////   w=new delegat(d.citizen("tiger",90)); //  لايجوز تعريف الميثود وضع قيم داخل الديلجيت .
        // pass delegate as parameter 

     delegat q = new delegat(d.citizen);
     delegat qq = new delegat(d.person);
        q("mgdy", 83);
        d.person(qq);Console.WriteLine(); // takes from delete qq from person
        d.person(q); // takes from delete q from citizen 


        

   
 
}



}