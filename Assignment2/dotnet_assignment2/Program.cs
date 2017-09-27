using System;

namespace dotnet_assignment2
{
    class Program
    {
        static void Main(){

             Console.WriteLine("Enter the size of the array");
             int x = int.Parse(Console.ReadLine());
             
             Arrayser A1 = new Arrayser();
             int ival = A1.PrintNumbers(x);

              // Console.WriteLine("value={0}",ival);


             Console.WriteLine("Enter the Fibonacci series limit");
             
             int limit =int.Parse(Console.ReadLine());

             Fibonacci F1=new Fibonacci();
             int z = F1.Printseries(limit);

             //Console.WriteLine("sum={0}",z);


             
        
            
        }
    }

   

   
}
