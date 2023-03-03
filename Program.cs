using System;

namespace MAD {
     class Program {            
          static void Main(string[] args) {
         bool TF = false;

   Console.Write("Input Number:");
   int number = int.Parse(Console.ReadLine());
   Console.Write("Input Kornpong:");
   string Kornpong = Console.ReadLine();


   int nb100K = number / 100000;
   int nb10K = (number / 10000) % 10;
   int nb1K = (number / 1000) % 10;
   int nb100 = (number / 100) % 10;
   int nb10 = (number / 10) % 10;
   int nb1 = number % 10;

   switch(Kornpong){
    case "CIA":
     if(nb1 % 3 == 0){
      if(nb10 != 1 && nb10 != 5 && nb10 != 3){
       if(nb1K != 8 && nb1K >= 6){
        Console.WriteLine("True");
       }
       else{
        Console.WriteLine("False");
       }
      }
      else{
       Console.WriteLine("False");
      }
     }
     else{
      Console.WriteLine("False");
     }
    break;

    case "FBI":
    if(nb100K >=4 && nb100K <=7){
        if(nb100 / 2 == 0 && nb100 != 6){
            if(nb10K / 2 == 1){

            }
        }
    }
     Console.WriteLine("True");
    break;

    case "NSA":
    if(nb1 == 1 && nb1 == 2 && nb1 == 3 && nb1 == 5 && nb1 == 6){
        if(nb100 / 3 == 0 && nb100 / 2 != 0){
            if(number == 7){

            }
        }
    }
     Console.WriteLine("True");
    break;

    default:
             Console.WriteLine("incorrect"); 
    break;
   }

   // Console.WriteLine("{0}",PW100K);
   // Console.WriteLine("{0}",PW10K);
   // Console.WriteLine("{0}",PW1K);
   // Console.WriteLine("{0}",PW100);
   // Console.WriteLine("{0}",PW10);
   // Console.WriteLine("{0}",PW1);
  }
 }
}
          
     
