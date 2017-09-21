using System;

namespace dotnet_assignment2
{
    class Program
    {
        static void Main(){

             Console.WriteLine("Enter the size of the array");
             int x = int.Parse(Console.ReadLine());
             Array A1 = new Array();
             A1.PrintNumbers(x);


             Console.WriteLine("Enter the Fibonacci series limit");
             
             int limit =int.Parse(Console.ReadLine());
             int i;
             int t1=0;
             int t2=1;
             int t3=0;
            Console.WriteLine("Fibonacci series :");
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            for(i=0;i<limit-2;i++)
            {
                t3=t1+t2;
                Console.WriteLine(t3);
                t1=t2;
                t2=t3;
            }


        
            
        }
    }

    class Array
    {
        
        

        public void PrintNumbers(int n)
        {
        int[] Numbers = new int [n];
            int i ;
            Console.WriteLine("Fill the array");
            for(i=0;i<n;i++){
                if(i<11){
                Numbers[i]= int.Parse(Console.ReadLine());
                }
                else
                {
                Console.WriteLine("Array crosses 10");
                break;
                }
                
            }
        }
        


    }
}
